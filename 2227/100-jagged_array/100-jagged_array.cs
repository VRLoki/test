using System;
using System.Linq;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = Enumerable.Range(0, 4).ToArray();
            jaggedArray[1] = Enumerable.Range(0, 7).ToArray();
            jaggedArray[2] = Enumerable.Range(0, 2).ToArray();

            foreach (int[] array in jaggedArray)
            {
                int lengthArray = array.Length;
                for (int i = 0; i < lengthArray; i++)
                {
                    Console.Write(array[i]);
                    if (i < lengthArray - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
