#include <unistd.h>
#include <sys/ptrace.h>
#include <sys/user.h>
#include <sys/wait.h>
#include <stdio.h>
#include <string.h>

#include "strace.h"

static void print_execve(syscall_t const syscalls[], size_t size)
{
	size_t i;
	syscall_t const *sys = NULL;

	for (i = 0; i < size; i++)
	{
		if (strcmp(syscalls[i].name, "execve") == 0)
		{
			sys = &syscalls[i];
			break;
		}
	}
	if (!sys)
		return;

	printf("%s(0, 0, 0) = 0\n", sys->name);
}

static void print_syscall_args(struct user_regs_struct const * const regs,
	syscall_t const *syscall)
{
	size_t i;

	if (!syscall)
		return;
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
		printf("%#lx", (unsigned long)reg_value);
	}
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

	(void)av;
	(void)env;
	if (is_child)
		print_execve(syscalls_64_g, ARRAY_SIZE(syscalls_64_g));
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
		print_syscall_args(&regs, syscall);

		if (wait_for_syscall(tracee) != 0)
			break;
		if (ptrace(PTRACE_GETREGS, tracee, NULL, &regs) == -1)
		{
			perror("ptrace");
			return (-1);
		}
		printf(") = %#lx\n", (unsigned long)regs.rax);
	}
	printf(") = ?\n");
	return (0);
}
