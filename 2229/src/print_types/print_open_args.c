#include <stdlib.h>
#include <stdio.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>

#include "syscalls.h"
#include "strace.h"

static bool_t print_open_flags(int flags)
{
	bool_t create = FALSE;

	if (flags & O_WRONLY)
		printf("O_WRONLY");
	else if (flags & O_RDWR)
		printf("O_RDWR");
	else
		printf("O_RDONLY");


	if (flags & O_APPEND)
		printf("|O_APPEND");
	if (flags & O_ASYNC)
		printf("|O_ASYNC");
	if (flags & O_CLOEXEC)
		printf("|O_CLOEXEC");
	if (flags & O_CREAT)
	{
		printf("|O_CREAT");
		create = TRUE;
	}
	/*if (flags & O_DIRECT)
		printf("|O_DIRECT");*/
	if (flags & O_DIRECTORY)
		printf("|O_DIRECTORY");
	if (flags & O_EXCL)
		printf("|O_EXCL");
	/*if (flags & O_LARGEFILE)
		printf("|O_LARGEFILE");*/
	/*if (flags & O_NOATIME)
		printf("|O_NOATIME");*/
	if (flags & O_NOCTTY)
		printf("|O_NOCTTY");
	if (flags & O_NOFOLLOW)
		printf("|O_NOFOLLOW");
	if (flags & O_NONBLOCK)
		printf("|O_NONBLOCK");
	if (flags & O_NDELAY)
		printf("|O_NDELAY");
	/*if (flags & O_PATH)
		printf("|O_PATH");*/
	if (flags & O_SYNC)
		printf("|O_SYNC");
	if (flags & O_TRUNC)
		printf("|O_TRUNC");

	return (create);
}

static void print_open_mode(int mode)
{
	if (mode & S_IRWXU)
		printf("|S_IRWXU");
	if (mode & S_IRUSR)
		printf("|S_IRUSR");
	if (mode & S_IWUSR)
		printf("|S_IWUSR");
	if (mode & S_IXUSR)
		printf("|S_IXUSR");
	if (mode & S_IRWXG)
		printf("|S_IRWXG");
	if (mode & S_IRGRP)
		printf("|S_IRGRP");
	if (mode & S_IWGRP)
		printf("|S_IWGRP");
	if (mode & S_IXGRP)
		printf("|S_IXGRP");
	if (mode & S_IRWXO)
		printf("|S_IRWXO");
	if (mode & S_IROTH)
		printf("|S_IROTH");
	if (mode & S_IWOTH)
		printf("|S_IWOTH");
	if (mode & S_IXOTH)
		printf("|S_IXOTH");

	printf(", ");
}

void print_open_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall)
{
	(void)tracee;
	(void)syscall;
	print_string(tracee, get_reg(regs, 0));
	printf(", ");
	if (print_open_flags(get_reg(regs, 1)))
	{
		printf(", ");
		print_open_mode(get_reg(regs, 2));
	}
}
