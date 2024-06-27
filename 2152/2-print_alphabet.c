#include <stdio.h>

/**
 * main - Entry point
 *
 * Description: prints alphabets in lowercase
 *
 * Return: Always 0
 */
int main(void)
{

	char n;

	for (n = 'a'; n <= 'z'; n++)
		putchar(n);
	putchar('\n');

	return (0);
}
