#include <stdio.h>

/**
 * main - Entry point
 *
 * Description: prints sum of multiples of 3 and 5 up to 1024
 *
 * Return: 0 (on success)
 */
int main(void)
{
	int i, sum = 0;

	for (i = 0; i < 1024; i++)
	{
		if ((i % 3) == 0 || (i % 5) == 0)
			sum += i;
	}
	printf("%d\n", sum);

	return (0);
}
