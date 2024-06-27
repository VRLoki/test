#include <stdio.h>
#include <stdlib.h>
#include "search_algos.h"

/**
* print_array - Prints an array of integers
*
* @array: The array to be printed
* @size: Number of elements in @array
*/
void print_array(const int *array, size_t size)
{
	size_t i;

	i = 0;

	while (array && i < size)
	{
		if (i > 0)
			printf(", ");
		printf("%d", array[i]);
		++i;
	}
	printf("\n");
}

/**
 * binary_search - serches an order list by deviding by 2
 * @array: array to search
 * @size: size of array
 * @value: value to find
 * Return: index or -1
 */
int binary_search(int *array, size_t size, int value)
{
	unsigned int i = ((size + (size % 2)) / 2) - 1;
	int ret = 0;

	if (!size || !array)
		return (-1);
	printf("Searching in array: ");
	print_array(array, size);
	if (array[i] > value)
		return (binary_search(array, i, value));
	if (array[i] < value)
	{
		ret = binary_search(array + i + 1, i - (size % 2) + 1, value);
		if (ret == -1)
			return (-1);
		return (ret + i + 1);
	}
	return (i);
}
