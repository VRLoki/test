#include <stdio.h>

/**
 * main - Entry point
 *
 * Description: prints the alphabet in reverse
 *
 * Return: Always 0
 */
int main(void)
{
	char n;

	for (n = 'z'; n >= 'a'; n--)
		putchar(n);
	putchar('\n');

	return (0);
}
