#include <stdlib.h>
#include <stdio.h>
#include <sys/mman.h>

#include "syscalls.h"
#include "strace.h"

static void print_mmap_prot(int prot)
{
	if (prot & PROT_NONE)
	{
		printf("PROT_NONE");
		return;
	}
	if (prot & PROT_READ)
		printf("PROT_READ");
	if (prot & PROT_WRITE)
		printf("|PROT_WRITE");
	if (prot & PROT_EXEC)
		printf("|PROT_EXEC");

	printf(", ");
}

static void print_mmap_flags(int flags)
{
	printf("%s", (flags & MAP_SHARED) ? "MAP_SHARED" : "MAP_PRIVATE");

	if (flags & MAP_32BIT)
		printf("|MAP_32BIT");
	/*if (flags & MAP_ANON)
		printf("|MAP_ANON");*/
	if (flags & MAP_FIXED)
		printf("|MAP_FIXED");
	if (flags & MAP_ANONYMOUS)
		printf("|MAP_ANONYMOUS");
	if (flags & MAP_DENYWRITE)
		printf("|MAP_DENYWRITE");
	if (flags & MAP_EXECUTABLE)
		printf("|MAP_EXECUTABLE");
	if (flags & MAP_FILE)
		printf("|MAP_FILE");
	if (flags & MAP_GROWSDOWN)
		printf("|MAP_GROWSDOWN");
	if (flags & MAP_HUGETLB)
		printf("|MAP_HUGETLB");
	if (flags & MAP_LOCKED)
		printf("|MAP_LOCKED");
	if (flags & MAP_NONBLOCK)
		printf("|MAP_NONBLOCK");
	if (flags & MAP_NORESERVE)
		printf("|MAP_NORESERVE");
	if (flags & MAP_POPULATE)
		printf("|MAP_POPULATE");
	if (flags & MAP_STACK)
		printf("|MAP_STACK");
	/*if (reg_value & MAP_UNINITIALIZED)
		printf("|MAP_UNINITIALIZED");*/

	printf(", ");
}

void print_mmap_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall)
{
	unsigned long int reg_value;

	(void)tracee;
	reg_value = get_reg(regs, 0);
	if (reg_value)
		print_addr(reg_value);
	else
		printf("NULL");
	printf(", ");
	print_value(get_reg(regs, 1), syscall->params[1]);
	printf(", ");
	print_mmap_prot(get_reg(regs, 2));
	print_mmap_flags(get_reg(regs, 3));
	print_value(get_reg(regs, 4), syscall->params[4]);
	printf(", ");
	print_value(get_reg(regs, 5), syscall->params[5]);
}
