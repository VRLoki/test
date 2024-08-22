using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonElements = new List<int>();

        foreach (int number in list1)
        {
            if (list2.Contains(number) && !commonElements.Contains(number))
                commonElements.Add(number);
        }
        return commonElements;
    }
}
