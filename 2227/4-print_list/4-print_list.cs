using System.Linq;
using System.Collections.Generic;
using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> numbers = Enumerable.Range(0, size).ToList();
        int lengthList = numbers.Count;

        for (int i = 0; i < lengthList; i++)
        {
            Console.Write(numbers[i]);
            if (i < lengthList - 1)
                Console.Write(" ");
        }

        Console.WriteLine();
        return numbers;
    }
}
