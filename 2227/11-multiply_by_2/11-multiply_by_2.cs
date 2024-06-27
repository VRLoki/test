using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        return myDict.ToDictionary(keyValue => keyValue.Key, keyValue => keyValue.Value *2);
    }
}
