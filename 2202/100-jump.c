#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include "search_algos.h"

/**
*jump_search - find index using jumpsearch algo
*@array: array to search
*@size: size of array
*@value: value to find
*Return: index found or -1
**/

int jump_search(int *array, size_t size, int value)
{
	int k = sqrt(size);
	int i;

	for (i = 0; i < size; i += k)
	{
		if (array[i] >= value)
			break;
		printf("Value checked array[%d] = [%d]\n", i, array[i]);
	}
	if (k != 0)
		printf("Value found between indexes [%d] and [%d]\n", i - k, i);
	for (i -= k; i < size; i++)
	{
		printf("Value checked array[%d] = [%d]\n", i, array[i]);
		if (array[i] == value)
			return (i);
	}
	return (-1);
}
