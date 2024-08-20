using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keysSorted = myDict.Keys.ToList();
        keysSorted.Sort();
        foreach (string key in keysSorted)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
