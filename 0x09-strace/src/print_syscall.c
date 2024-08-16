#include <stdlib.h>
#include <sys/user.h>
#include <stdio.h>
#include <string.h>

#include "strace.h"

syscall_t const *print_syscall_name(struct user_regs_struct const * const regs)
{
	syscall_t const *syscall;

	if ((int)regs->orig_rax != -1)
	{
		syscall = get_syscall_by_id(syscalls_64_g, regs->orig_rax);
		if (!syscall)
		{
			printf("UNKNOWN");
			return (NULL);
		}

		printf("%s", syscall->name);
		return (syscall);
	}
	return (NULL);
}
