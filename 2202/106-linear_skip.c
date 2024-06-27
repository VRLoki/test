#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include "search_algos.h"

/**
*linear_skip - find node using jumpsearch algo
*@list: list to search
*@value: value to find
*Return: pointer to node or -1
**/

skiplist_t *linear_skip(skiplist_t *list, int value)
{
	skiplist_t *tmp = list;

	if (!list)
		return (NULL);
	while (list)
	{
		list =  list->express;
		printf("Value checked at index [%ld] = [%d]\n", list->index, list->n);
		if (list->n >= value)
			break;
		tmp = list;
		if (!(list->express))
		{
			while (list->next)
				list = list->next;
			break;
		}
	}
	printf("Value found between indexes ");
	printf("[%ld] and [%ld]\n", tmp->index, list->index);
	for (list = tmp; list ; list =  list->next)
	{
		printf("Value checked at index [%ld] = [%d]\n", list->index, list->n);
		if (list->n == value)
			return (list);
	}
	return (NULL);
}
