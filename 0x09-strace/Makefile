################################################################################
# 'strace' sources
################################################################################
SRCS_DIR	= src
SRCS		= $(SRCS_DIR)/main.c \
		$(SRCS_DIR)/get_pid_to_trace.c \
		$(SRCS_DIR)/wait_for_syscall.c \
		$(SRCS_DIR)/utils.c \
		$(SRCS_DIR)/get_syscall_by_id.c \
		$(SRCS_DIR)/print_syscall.c \
		$(SRCS_DIR)/get_reg.c \
		$(SRCS_DIR)/print_value.c \
		$(SRCS_DIR)/print_types/print_string.c \
		$(SRCS_DIR)/print_types/print_integers.c \
		$(SRCS_DIR)/print_types/print_null_pointer.c \
		$(SRCS_DIR)/print_types/print_mmap_args.c \
		$(SRCS_DIR)/print_types/print_open_args.c \
		$(SRCS_DIR)/print_types/print_access_args.c \
		$(SRCS_DIR)/print_types/print_read_args.c \
		$(SRCS_DIR)/print_types/print_write_args.c \
		$(SRCS_DIR)/print_types/print_fstat_args.c

INCS_DIR	= inc
SYSCALLS	= $(INCS_DIR)/syscalls.h

OBJS_DIR	= build
OBJS		= $(SRCS:%.c=$(OBJS_DIR)/%.o)
TMPS		= $(SRCS:.c=.c~)

################################################################################
# gcc
################################################################################
CC		= gcc
CFLAGS		= -I$(INCS_DIR)
CFLAGS		+= -Wall -Wextra -Werror -pedantic -g3

################################################################################
# Rules
################################################################################
all		: strace_0 strace_1 strace_2 strace_3 strace_4 strace_5 \
		strace_6 strace_7 strace_8

strace_0	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_0.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_0.o

strace_1	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_1.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_1.o

strace_2	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_2.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_2.o

strace_3	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_3.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_3.o

strace_4	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_4.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_4.o

strace_5	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_5.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_5.o

strace_6	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_6.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_6.o

strace_7	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_7.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_7.o

strace_8	: $(SYSCALLS) $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_8.o
		$(CC) -o $@ $(OBJS) $(OBJS_DIR)/$(SRCS_DIR)/trace_8.o

$(SYSCALLS)	:
		ruby get_syscalls.rb

$(OBJS_DIR)/%.o	: %.c
		mkdir -p $(@D)
		$(CC) $(CFLAGS) -c -o $@ $<

.PHONY		: clean
clean		:
		$(RM) -r $(OBJS_DIR)
		$(RM) $(TMPS)

.PHONY		: fclean
fclean		: clean
		$(RM) strace_0
		$(RM) strace_1
		$(RM) strace_2
		$(RM) strace_3
		$(RM) strace_4
		$(RM) strace_5
		$(RM) strace_6
		$(RM) strace_7
		$(RM) strace_8

.PHONY		: re
re		: fclean all
