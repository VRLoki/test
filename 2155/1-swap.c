#include "main.h"

/**
 * swap_int - swaps the values of two integers
 * @a: first int
 * @b: second int
 *
 * Return: None (void)
 */
void swap_int(int *a, int *b)
{
	int c = *a;
	*a = *b;
	*b = c;
}
