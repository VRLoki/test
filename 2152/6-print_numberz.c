#include <stdio.h>

/**
 * main - Entry point
 *
 * Description: prints numbers 0 to 9 using putchar
 *
 * Return: Always 0
 */
int main(void)
{
	int n;

	for (n = 0; n < 10; n++)
		putchar('0' + n);
	putchar('\n');

	return (0);
}
