#include <stdlib.h>

#include "strace.h"

void print_value(unsigned long int value, type_t type)
{
	struct
	{
		type_t type;
		void (*printer)(unsigned long int);
	} types_handlers[10] = {
		{INT, &print_signed_32},
		{LONG, &print_signed_64},
		{SIZE_T, &print_unsigned_64},
		{SSIZE_T, &print_unsigned_64},
		{U64, &print_unsigned_64},
		{UNSIGNED_INT, &print_unsigned_32},
		{UNSIGNED_LONG, &print_unsigned_64},
		{PID_T, &print_signed_64},
		{UINT32_T, &print_unsigned_32},
		{0, NULL}
	};
	size_t i;

	for (i = 0; types_handlers[i].printer; i++)
	{
		if (types_handlers[i].type == type)
		{
			types_handlers[i].printer(value);
			return;
		}
	}

	/* DEFAULT */
	print_addr(value);
}
