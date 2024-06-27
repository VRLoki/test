#include <stdio.h>
#include <stdlib.h>
#include "search_algos.h"
/**
 * interpolation_search - finds value in array with interpolation method
 * @array: array to search
 * @size: size of array
 * @value: value to find
 * Return: index or -1
 */
int interpolation_search(int *array, size_t size, int value)
{
	int lo;
	int hi;
	size_t pos;

	if (!size || !array)
		return (-1);
	lo = 0;
	hi = size - 1;
	while (1)
	{
		pos = lo;
		pos += ((double)(hi - lo) / (array[hi] - array[lo])) * (value - array[lo]);
		if (pos > size)
		{
			printf("Value checked array[%ld] is out of range\n", pos);
			return (-1);
		}
		printf("Value checked array[%ld] = [%d]\n", pos, array[pos]);
		if (array[pos] == value)
			return (pos);
		if (array[pos] > value)
			hi = pos - 1;
		if (array[pos] < value)
			lo = pos + 1;
	}
}
