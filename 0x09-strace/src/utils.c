#include <ctype.h>

#include "strace.h"

/**
 * is_num - Checks wether a string is a number
 *
 * @s: String to be checked
 *
 * Return: TRUE or FALSE
 */
bool_t is_num(const char *s)
{
	for (; s && *s; s++)
	{
		if (!isdigit(*s))
			return (FALSE);
	}
	return (TRUE);
}
