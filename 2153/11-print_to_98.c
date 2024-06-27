#include <stdio.h>
#include "main.h"

/**
 * print_to_98 - prints integers up/down to 98
 * @n: number from which to start check
 *
 * Return: None (void)
 */
void print_to_98(int n)
{
	int i = 0;

	if (n > 98)
		for (i = n; i > 98; i--)
			printf("%d, ", i);

	else
		for (i = n; i < 98; i++)
			printf("%d, ", i);

	printf("98");

	printf("\n");
}
