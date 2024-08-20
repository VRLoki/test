using System.Linq;
using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
            Console.WriteLine();

        int[] numbers = Enumerable.Range(0, size).ToArray();
        int lengthArray = numbers.Length;
        for (int i = 0; i < lengthArray; i++)
        {
            if (i < lengthArray - 1)
                Console.Write($"{numbers[i]} ");
            else
                Console.WriteLine($"{numbers[i]}");
        }
        return numbers;
    }
}