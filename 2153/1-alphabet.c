#include "main.h"

/**
 * print_alphabet - prints the lowercase alphabet
 *
 * Return: None (void)
 */
void print_alphabet(void)
{
	char c;

	c = 'a';
	while (c <= 'z')
	{
		_putchar(c);
		c++;
	}
	_putchar('\n');

}
