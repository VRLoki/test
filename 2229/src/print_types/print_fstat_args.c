#include <stdlib.h>
#include <stdio.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <unistd.h>
#include <sys/ptrace.h>
#include <errno.h>
#include <string.h>

#include "syscalls.h"
#include "strace.h"

static void print_fstat_st_mode(mode_t st_mode)
{
	if (S_ISBLK(st_mode))
		printf("S_IFBLK");
	if (S_ISCHR(st_mode))
		printf("S_IFCHR");
	if (S_ISFIFO(st_mode))
		printf("S_IFIFO");
	if (S_ISREG(st_mode))
		printf("S_IFREG");
	if (S_ISDIR(st_mode))
		printf("S_IFDIR");
	if (S_ISLNK(st_mode))
		printf("S_IFLNK");
	if (S_ISSOCK(st_mode))
		printf("S_IFSOCK");

	printf("|%d%d%d%d", (st_mode / (8 * 8 * 8)) % 8,
		(st_mode / (8 * 8)) % 8, (st_mode / 8) % 8, st_mode % 8);

	printf(", ");
}

void print_fstat_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall)
{
	unsigned long int addr;
	char *buf;
	size_t read = 0;
	unsigned long tmp = 0;

	(void)syscall;
	print_signed_32(get_reg(regs, 0));
	printf(", ");
	addr = get_reg(regs, 1);
	buf = malloc(sizeof(struct stat));
	while (read < sizeof(struct stat))
	{
		tmp = ptrace(PTRACE_PEEKDATA, tracee, addr + read);
		if (errno != 0)
		{
			buf[read] = 0;
			break;
		}
		memcpy(buf + read, &tmp, sizeof(tmp));
		read += sizeof(tmp);
	}
	printf("{st_mode=");
	print_fstat_st_mode(((struct stat *)(buf))->st_mode);
	printf("st_size=%lu, ...}", ((struct stat *)(buf))->st_size);
}
