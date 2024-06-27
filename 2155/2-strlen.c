#include "main.h"

/**
 * _strlen - returns length of string
 * @s: string to return length of
 *
 * Return: string length
 */
int _strlen(char *s)
{
	int i;

	for (i = 0; s[i]; i++)
		;
	return (i);
}
