using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        Console.WriteLine($"{new StringBuilder(str.Length * 3).Insert(0, str, 3)}");
        Console.WriteLine($"{str.Substring(0, 9)}");
    }
}