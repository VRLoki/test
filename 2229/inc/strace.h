#ifndef _STRACE_H_
# define _STRACE_H_

# include <stddef.h>
# include <unistd.h>
# include <sys/user.h>

# include "syscalls.h"

# define get_syscall_by_id(s, i) _get_syscall_by_id(s, ARRAY_SIZE(s), i)
# define ARRAY_SIZE(a) (sizeof(a) / sizeof(a[0]))
# define SYSCALL_OPCODE 0x3D48

typedef enum bool_e
{
	FALSE = 0,
	TRUE
} bool_t;

pid_t get_pid_to_trace(char **av);
pid_t exec_command(char **av, char **env);
bool_t is_pid_running(pid_t pid);
bool_t is_num(const char *s);
int trace_pid(pid_t tracee, bool_t is_child, char **av, char **env);
int wait_for_syscall(pid_t tracee);
syscall_t const *print_syscall_name(struct user_regs_struct const * const regs);

/* PRINT_TYPES */
syscall_t const *_get_syscall_by_id(syscall_t const syscalls[],
	size_t size, size_t id);
unsigned long int get_reg(struct user_regs_struct const * const regs,
	size_t param_nb);
void print_value(unsigned long int value, type_t type);
void print_string(pid_t tracee, unsigned long int addr);
void print_unsigned_32(unsigned long int value);
void print_unsigned_64(unsigned long int value);
void print_signed_32(unsigned long int value);
void print_signed_64(unsigned long int value);
void print_addr(unsigned long int value);
bool_t print_null_pointer(unsigned long int value, type_t type);
void print_mmap_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall);
void print_open_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall);
void print_access_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall);
void print_read_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall);
void print_write_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall);
void print_fstat_args(pid_t tracee, struct user_regs_struct const * const regs,
	syscall_t const *syscall);

#endif /* _STRACE_H_ */
