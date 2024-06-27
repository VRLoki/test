#include <stdio.h>

/**
 * main - Entry point
 *
 * Description: prints the first 98 fibonacci numbers
 *
 * Return: 0
 */
int main(void)
{
	unsigned long prev = 1, curr = 2, next;

	printf("%lu, %lu", prev, curr);

	for (int i = 3; i <= 98; i++)
	{
		next = prev + curr;
		prev = curr;
		curr = next;
		printf(", %lu", curr);
	}

	printf("\n");
	return (0);
}
