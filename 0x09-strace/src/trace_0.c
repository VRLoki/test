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

	printf("%lu\n", syscalls[i].nr);
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

	(void)env;
	(void)av;
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
		printf("%lu\n", (unsigned long)regs.orig_rax);

		if (wait_for_syscall(tracee) != 0)
			break;
		if (ptrace(PTRACE_GETREGS, tracee, NULL, &regs) == -1)
		{
			perror("ptrace");
			return (-1);
		}
	}
	return (0);
}
