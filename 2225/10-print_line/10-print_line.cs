using System;

class Line
{
    public static void PrintLine(int length)
    {
        string line = "";

        for (int i = 0; i < length; i++)
            line += "_";
        Console.WriteLine(line);
    }
}