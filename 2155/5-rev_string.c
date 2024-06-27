#include "main.h"

/**
 * rev_string - reverses a string
 * @s: the string to reverse
 *
 * Return: None (void)
 */
void rev_string(char *s)
{
	int i, l;
	char c;

	for (l = 0; s[l]; l++)
		;
	for (i = 0; i < (l / 2); i++)
	{
		c = s[i];
		s[i] = s[l - 1 - i];
		s[l - 1 - i] = c;
	}
}
