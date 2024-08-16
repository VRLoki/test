#!/bin/bash

counter=0
while [ $counter -le 5 ]
do
	./strace_$counter /bin/echo Holberton > output_$counter
	((counter++))
done
