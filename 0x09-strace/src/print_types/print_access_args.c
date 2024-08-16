#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>

#include "syscalls.h"
#include "strace.h"

static void print_access_mode(int mode)
{
	size_t count = 0;

	if (mode == F_OK)
	{
		printf("F_OK");
		return;
	}

	if (mode & R_OK)
	{
		printf("R_OK");
		count++;
	}
	if (mode & W_OK)
	{
		if (count > 0)
			printf("|");
		printf("W_OK");
		count++;
	}
	if (mode & X_OK)
	{
		if (count > 0)
			printf("|");
		printf("X_OK");
	}
}

void print_access_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall)
{
	(void)tracee;
	(void)syscall;
	print_string(tracee, get_reg(regs, 0));
	printf(", ");
	print_access_mode(get_reg(regs, 1));
}
