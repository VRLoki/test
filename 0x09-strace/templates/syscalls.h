#ifndef _SYSCALLS_H_
# define _SYSCALLS_H_

# include <stddef.h>

/* Normally, MAX_PARAMS is always 6 */
# define MAX_PARAMS	<%MAX_PARAMS%>

/**
 * enum type_e - Enumerates the different types present in the different
 * syscall parameters and return types
 */
typedef enum type_e
{
	<%TYPES%>
} type_t;

/**
 * struct syscall_s - Stores information about a syscall
 *
 * @name: Name of the syscall
 * @nr: Syscall number in the syscalls table
 * @ret: Return type
 * @nb_params: Number of parameters
 * @params: Array of parameters types
 */
typedef struct syscall_s
{
	char const * const name;
	size_t const nr;
	type_t const ret;
	size_t const nb_params;
	type_t const params[MAX_PARAMS];
} syscall_t;

static syscall_t const syscalls_64_g[] = {
	<%SYSCALLS_64%>
};

static syscall_t const syscalls_32_g[] = {
	<%SYSCALLS_32%>
};

#endif /* !_SYSCALLS_H_ */
