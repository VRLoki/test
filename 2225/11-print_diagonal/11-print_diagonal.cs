using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        string line = "";
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < i; j++)
                line += " ";
            line += "\\\n";
        }
        Console.WriteLine(line);
    }
}