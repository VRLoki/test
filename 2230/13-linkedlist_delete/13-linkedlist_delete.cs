using System.Collections.Generic;
using System.Linq;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
        if (index < 0 || index >= myLList.Count)
			return;
		myLList.Remove(myLList.ElementAt(index));
	}
}
