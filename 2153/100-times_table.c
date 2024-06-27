#include "main.h"

/**
 * print_times_table - prints the multiplication table between 0 and 15
 * @n: input integer
 *
 * Return: None (void)
 */
void print_times_table(int n)
{
	int i, j, num;

	if (n > 15 || n < 0)
		return;

	for (i = 0; i <= n; i++)
	{
		for (j = 0; j <= n; j++)
		{
			num = (i * j);
			if (j != 0)
				_putchar(',');
			if (j != 0 && num < 10)
				_putchar(' '), _putchar(' ');
			else if (j != 0 && num < 100)
				_putchar(' '), _putchar((num / 10) + '0');
			else if (j != 0)
				_putchar((num / 100) + '0'), _putchar((num / 10) % 10 + '0');

			_putchar((num % 10) + '0');
			if (j == n)
				_putchar('\n');
			else
				_putchar(' ');
		}
	}
}
