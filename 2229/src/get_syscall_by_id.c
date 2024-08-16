#include <stdlib.h>
#include "strace.h"

/**
 * _get_syscall_by_id - Get information about a syscall by its ID
 *
 * @syscalls: Array of syscalls (64bit or 32bit)
 * @size: Size of the array @syscalls
 * @id: ID of the syscall to locate
 *
 * Return: A pointer to the corresponding syscall structure, or NULL
 * if not found
 */
syscall_t const *_get_syscall_by_id(syscall_t const syscalls[],
	size_t size, size_t id)
{
	size_t i;

	i = id < size ? id : size - 1;
	while (syscalls[i].nr > i)
		++i;

	return (syscalls[i].nr == i ? &syscalls[i] : NULL);
}
