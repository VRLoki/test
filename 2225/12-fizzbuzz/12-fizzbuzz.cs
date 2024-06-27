﻿using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0)
                        Console.Write("Fizz");
                    if (i % 5 == 0)
                        Console.Write("Buzz");
                }
                else
                    Console.Write($"{i}");
                if (i < 100)
                    Console.Write(" ");
                else
                    Console.WriteLine();
            }
        }
    }
}
