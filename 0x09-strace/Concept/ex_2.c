#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/ptrace.h>
#include <sys/wait.h>
#include <sys/user.h>

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
		kill(getpid(), SIGSTOP);
		execve(cmd[0], cmd, env);
	}
	else
	{
		/* Parent */
		int status;

		while (98)
		{
			struct user_regs_struct regs;

			/* Syscall */
			waitpid(pid, &status, 0);
			if (WIFEXITED(status))
			{
				printf("Exit status: %d\n", WEXITSTATUS(status));
				return (status);
			}
			if (ptrace(PTRACE_GETREGS, pid, NULL, &regs) == -1)
			{
				perror("ptrace");
				return (-1);
			}
			printf("%lu\n", (unsigned long)regs.orig_rax);
			if (ptrace(PTRACE_SYSCALL, pid, NULL, NULL) == -1)
			{
				perror("ptrace1");
				return (-1);
			}

			/* Return */
			waitpid(pid, &status, 0);
			if (WIFEXITED(status))
			{
				printf("Exit status: %d\n", WEXITSTATUS(status));
				return (status);
			}
			if (ptrace(PTRACE_SYSCALL, pid, NULL, NULL) == -1)
			{
				perror("ptrace2");
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
