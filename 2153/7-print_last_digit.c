#include "main.h"

/**
 * print_last_digit - prints the last digit of a number
 * @n: the number to check
 *
 * Return: the value of the last digit
 */
int print_last_digit(int n)
{
	int i;

	i = n % 10;
	if (n < 0)
		i *= -1;

	_putchar('0' + i);

	return (i);
}
