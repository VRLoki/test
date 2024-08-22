using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> numbers = new LinkedList<int>();
        if (size < 0)
            return numbers;
        for (int i = 0; i < size; i++)
        {
            numbers.AddLast(i);
            System.Console.WriteLine(numbers.ElementAt(i));
        }
        return numbers;
    }
}
