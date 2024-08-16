#include <unistd.h>
#include <stdio.h>
#include <sys/ptrace.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>

#include "strace.h"

/**
 * print_string - Retrieves a memory area from the process being traced, and
 * print this memory area as a string of characters
 *
 * @tracee: PID of the process being traced
 * @addr: Address of the memory area in the process being traced
 */
void print_string(pid_t tracee, unsigned long int addr)
{
	char val[4096];
	size_t read = 0;
	unsigned long tmp = 0;

	while (1)
	{
		tmp = ptrace(PTRACE_PEEKDATA, tracee, addr + read);
		if (errno != 0)
		{
			val[read] = 0;
			break;
		}
		memcpy(val + read, &tmp, sizeof(tmp));
		if (memchr(&tmp, 0, sizeof(tmp)) != NULL)
			break;
		read += sizeof(tmp);
	}
	printf("\"%s\"", val);
}
