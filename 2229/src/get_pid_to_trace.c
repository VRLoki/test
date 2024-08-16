#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/ptrace.h>
#include <signal.h>
#include <errno.h>

#include "strace.h"

/**
 * get_pid_to_trace - Retrieve PID given in command-line arguments
 *
 * @av: Command-line arguments vector
 *
 * Return: The PID of the process to be traced, or -1 on error
 */
pid_t get_pid_to_trace(char **av)
{
	pid_t pid;

	if (strcmp(av[0], "-p") == 0)
	{
		if (!av[1] || !is_num(av[1]))
		{
			fprintf(stderr, "Invalid PID\n");
			return (-1);
		}
		pid = atoi(av[1]);
	}
	else if (strncmp(av[0], "-p", 2) == 0)
	{
		if (!is_num(av[0] + 2))
		{
			fprintf(stderr, "Invalid PID\n");
			return (-1);
		}
		pid = atoi(av[0] + 2);
	}

	return (pid);
}

/**
 * exec_command - If no PID is given in the command-line arguments,
 * The command given in the command-line arguments is executed.
 * A forked process is launched to host the command to launch, and this process
 * is traced
 *
 * @av: Command-line arguments vector
 * @env: Environment
 *
 * Return: The PID of the child process to be traced, or -1 on error
 */
pid_t exec_command(char **av, char **env)
{
	pid_t pid;

	pid = fork();
	if (pid == -1)
	{
		perror("fork");
		return (-1);
	}
	if (pid == 0)
	{
		if (ptrace(PTRACE_TRACEME, pid, NULL, NULL) == -1)
		{
			perror("ptrace");
			return (-1);
		}
		execve(av[0], av, env);
		perror("execve");
		exit(-1);
	}

	return (pid);
}

/**
 * is_pid_running - Utility function to check if a given PID
 * corresponds to a running process
 *
 * @pid: PID to be checked
 *
 * Return: TRUE or FALSE
 */
bool_t is_pid_running(pid_t pid)
{
	if (kill(pid, 0) == -1 && errno == ESRCH)
		return (FALSE);

	return (TRUE);
}
