using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> isDivisibleBy2 = new List<bool>();
        isDivisibleBy2.AddRange(myList.ConvertAll(n => n % 2 == 0));
        return isDivisibleBy2;
    }
}
