#include <stdio.h>
#include <stdlib.h>
#include "search_algos.h"

/**
 * linear_search - finds a value linearly
 * @array: array to search
 * @size: size of array
 * @value: value to find
 * Return: Index or -1
 */
int linear_search(int *array, size_t size, int value)
{
	unsigned int i;

	for (i = 0; i < size; i++)
	{
		printf("Value checked array[%d] = [%d]\n", i, array[i]);
		if (value == array[i])
			return (i);
	}
	return (-1);
}
