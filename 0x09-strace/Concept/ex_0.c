#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/ptrace.h>
#include <sys/wait.h>

int exec_and_trace(char **cmd, char **env)
{
	pid_t pid;

	pid = fork();
	if (pid == -1)
	{
		perror("fork");
		return (-1);
	}
	else if (pid == 0)
	{
		/* CHILD */
		ptrace(PTRACE_TRACEME, 0, NULL, NULL);
		execve(cmd[0], cmd, env);
	}
	else
	{
		/* Parent */
		int status;

		while (98)
		{
			waitpid(pid, &status, 0);
			if (WIFEXITED(status))
			{
				printf("Exit status: %d\n", WEXITSTATUS(status));
				return (status);
			}

			printf("single step\n");

			if (ptrace(PTRACE_SINGLESTEP, pid, NULL, NULL) == -1)
			{
				perror("ptrace");
				return (-1);
			}
		}
	}
	return (0);
}

int main(int ac, char **av, char **env)
{
	if (ac < 2)
	{
		fprintf(stderr, "Usage: %s command to execute\n", av[0]);
		return (EXIT_FAILURE);
	}

	if (exec_and_trace(av + 1, env) == -1)
		return (EXIT_FAILURE);

	return (EXIT_SUCCESS);
}
