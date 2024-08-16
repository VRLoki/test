#include <sys/user.h>
#include <stdlib.h>

#include "strace.h"
/**
 * get_reg - Get the corresponding register depending
 * on the syscall parameter index
 *
 * @regs: Registers of the process being traced after the syscall has been done
 * @param_nb: Index of the parameter to get the corresponding register
 *
 * Return: Value stored in the corresponding register, 0 if not found
 */
unsigned long int get_reg(struct user_regs_struct const * const regs,
	size_t param_nb)
{
	switch (param_nb)
	{
	case -1:
		return (regs->rax);
	case 0:
		return (regs->rdi);
	case 1:
		return (regs->rsi);
	case 2:
		return (regs->rdx);
	case 3:
		return (regs->r10);
	case 4:
		return (regs->r8);
	case 5:
		return (regs->r9);
	}

	return (0);
}
