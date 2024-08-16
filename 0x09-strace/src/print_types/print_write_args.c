#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>
#include <errno.h>
#include <sys/ptrace.h>
#include <string.h>

#include "syscalls.h"
#include "strace.h"

static void print_octal(unsigned char c)
{
	if (c >= 8)
		print_octal(c / 8);
	printf("%d", c % 8);
}

static void print_write_buffer(char const *buf, size_t len)
{
	size_t i;

	printf("\"");
	for (i = 0; i < len && buf[i]; i++)
	{
		if (buf[i] <= 31 || buf[i] >= 127)
		{
			if (buf[i] == '\a')
				printf("\\a");
			else if (buf[i] == '\b')
				printf("\\b");
			else if (buf[i] == '\t')
				printf("\\t");
			else if (buf[i] == '\n')
				printf("\\n");
			else if (buf[i] == '\v')
				printf("\\v");
			else if (buf[i] == '\f')
				printf("\\f");
			else if (buf[i] == '\r')
				printf("\\r");
			else
			{
				printf("\\");
				print_octal(buf[i]);
			}
		}
		else
		{
			printf("%c", buf[i]);
		}
	}
	printf("\"");
}

void print_write_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall)
{
	unsigned long int addr;
	size_t count, len;
	char *buf;
	size_t read = 0;
	unsigned long tmp = 0;

	(void)syscall;
	print_signed_32(get_reg(regs, 0));
	printf(", ");
	addr = get_reg(regs, 1);
	count = get_reg(regs, 2);
	len = count > 32 ? 32 : count;

	buf = malloc(sizeof(*buf) * len);
	while (read < len)
	{
		tmp = ptrace(PTRACE_PEEKDATA, tracee, addr + read);
		if (errno != 0)
		{
			buf[read] = 0;
			break;
		}
		memcpy(buf + read, &tmp, sizeof(tmp));
		if (memchr(&tmp, 0, sizeof(tmp)) != NULL)
			break;
		read += sizeof(tmp);
	}
	print_write_buffer(buf, len);
	if (len < count)
		printf("...");
	printf(", ");
	print_unsigned_64(count);
}
