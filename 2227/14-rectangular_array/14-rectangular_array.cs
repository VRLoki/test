using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5];
            numbers[2, 2] = 1;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int lengthColumn = numbers.GetLength(1);
                for (int j = 0; j < lengthColumn; j++)
                {
                    Console.Write(numbers[i, j]);
                    if (j < lengthColumn - 1)
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
