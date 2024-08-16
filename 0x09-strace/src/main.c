#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/wait.h>
#include <sys/ptrace.h>

#include "strace.h"

/**
 * main - Entry point
 *
 * @ac: Arguments counter
 * @av: Arguments vector
 * @env: Environment
 *
 * Return: EXIT_SUCCESS or EXIT_FAILURE
 * TODO: Should exit with tracee's exit status
 */
int main(int ac, char **av, char **env)
{
	pid_t pid_traced;
	int status;
	bool_t is_child = FALSE;

	if (ac < 2)
	{
		fprintf(stderr, "Usage: %s -ppid / command [args...]\n", av[0]);
		return (EXIT_FAILURE);
	}

	if (strncmp(av[1], "-p", 2) == 0)
	{
		pid_traced = get_pid_to_trace(av + 1);
	}
	else
	{
		pid_traced = exec_command(av + 1, env);
		is_child = TRUE;
	}
	if (pid_traced == -1)
		return (EXIT_FAILURE);
	else if (!is_pid_running(pid_traced))
	{
		fprintf(stderr, "No running program with PID %d\n", pid_traced);
		return (EXIT_FAILURE);
	}

	waitpid(pid_traced, &status, 0);
	ptrace(PTRACE_SETOPTIONS, pid_traced, 0, PTRACE_O_TRACESYSGOOD);
	return (trace_pid(pid_traced, is_child, av + 1, env));
}
