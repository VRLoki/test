#include <stdio.h>

/**
 * main - Entry point
 *
 * Description: prints the string _putchar
 *
 * Return: 0 (on success)
 */
int main(void)
{
	int i = 0;
	char c;
	char s[] = "_putchar";

	while (i <= 7)
	{
		c = s[i];
		putchar(c);
		i++;
	}
	putchar('\n');

	return (0);
}
