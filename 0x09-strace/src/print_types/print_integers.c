#include <stdio.h>

void print_unsigned_32(unsigned long int value)
{
	printf("%u", (unsigned int)value);
}

void print_unsigned_64(unsigned long int value)
{
	printf("%lu", value);
}

void print_signed_32(unsigned long int value)
{
	printf("%d", (signed int)value);
}

void print_signed_64(unsigned long int value)
{
	printf("%ld", (signed long int)value);
}

void print_addr(unsigned long int value)
{
	printf("%#lx", value);
}
