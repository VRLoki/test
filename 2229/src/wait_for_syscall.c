#include <stdlib.h>
#include <sys/ptrace.h>
#include <sys/wait.h>
#include <stdio.h>

#include "strace.h"

int wait_for_syscall(pid_t tracee)
{
	int status;

	fflush(stdout);
	fflush(stderr);
	while (TRUE)
	{
		ptrace(PTRACE_SYSCALL, tracee, 0, 0);
		waitpid(tracee, &status, 0);
		if (WIFSTOPPED(status) && WSTOPSIG(status) & 0x80)
			return (0);
		if (WIFEXITED(status))
			return (1);
	}
	return (1);
}
