#include <unistd.h>
#include <sys/ptrace.h>
#include <sys/user.h>
#include <sys/wait.h>
#include <stdio.h>
#include <string.h>

#include "strace.h"

static void print_execve(char **av, char **env)
{
	size_t i;

	printf("execve(\"%s\", [", av[0]);
	for (i = 0; av && av[i]; i++)
	{
		if (i)
			printf(", ");
		printf("\"%s\"", av[i]);
	}
	for (i = 0; env && env[i]; i++);
	printf("], [/* %lu vars */]) = 0\n", i);
}

static void print_syscall_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall)
{
	size_t i;

	for (i = 0; i < syscall->nb_params; i++)
	{
		unsigned long int reg_value;
		type_t param_type = syscall->params[i];

		if (param_type == VOID || param_type == (type_t)-1)
			break;

		if (i > 0)
			printf(", ");

		if (param_type == VARARGS)
		{
			printf("...");
			continue;
		}

		reg_value = get_reg(regs, i);
		if (print_null_pointer(reg_value, param_type))
			continue;

		if (param_type == CHAR_P)
			print_string(tracee, reg_value);
		else
			print_value(reg_value, param_type);
	}
}

static bool_t print_special(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall)
{
	struct {
		char const * const name;
		void (*print_args)(pid_t tracee,
			struct user_regs_struct const * const regs,
			syscall_t const *syscall);
	} special[] = {
		{"mmap", &print_mmap_args},
		{"open", &print_open_args},
		{"access", &print_access_args}
	};
	size_t i;
	bool_t found = FALSE;

	for (i = 0; i < ARRAY_SIZE(special); i++)
	{
		if (strcmp(syscall->name, special[i].name) == 0)
		{
			found = TRUE;
			special[i].print_args(tracee, regs, syscall);
			break;
		}
	}

	return (found);
}

/**
 * trace_pid - Trace a running process already attached
 *
 * @tracee: PID of the process being traced
 * @av: Arguments vector
 * @env: Environment
 *
 * Return: 0 on success, -1 on error
 */
int trace_pid(pid_t tracee, bool_t is_child, char **av, char **env)
{
	struct user_regs_struct regs;
	syscall_t const *syscall;

	if (is_child)
		print_execve(av, env);
	while (TRUE)
	{
		if (wait_for_syscall(tracee) != 0)
			break;
		if (ptrace(PTRACE_GETREGS, tracee, NULL, &regs) == -1)
		{
			perror("ptrace");
			return (-1);
		}
		syscall = print_syscall_name(&regs);
		printf("(");

		if (!print_special(tracee, &regs, syscall))
			print_syscall_args(tracee, &regs, syscall);

		if (wait_for_syscall(tracee) != 0)
			break;
		if (ptrace(PTRACE_GETREGS, tracee, NULL, &regs) == -1)
		{
			perror("ptrace");
			return (-1);
		}
		printf(") = ");
		print_value(regs.rax, syscall->ret);
		printf("\n");
	}
	printf(") = ?\n");
	return (0);
}
