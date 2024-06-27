#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include "search_algos.h"

/**
*jump_list - find node using jumpsearch algo
*@list: list to search
*@size: size of array
*@value: value to find
*Return: pointer to node or -1
**/

listint_t *jump_list(listint_t *list, size_t size, int value)
{
	int k = sqrt(size);
	int i;
	listint_t *tmp = list;

	if (!list || !size)
		return (NULL);
	while (list)
	{
		for (i = 0; i < k && list->next	; i++)
			list =  list->next;
		printf("Value checked at index [%ld] = [%d]\n", list->index, list->n);
		if (list->n >= value || !(list->next))
			break;
		tmp = list;
	}
	if (k != 0)
	{
		printf("Value found between indexes ");
		printf("[%ld] and [%ld]\n", tmp->index, list->index);
	}
	for (list = tmp; list ; list =  list->next)
	{
		printf("Value checked at index [%ld] = [%d]\n", list->index, list->n);
		if (list->n == value)
			return (list);
	}
	return (NULL);
}
