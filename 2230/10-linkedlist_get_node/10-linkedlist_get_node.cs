using System.Collections.Generic;
using System.Linq;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
        if (n < 0 || myLList.Count <= n)
			return 0;
		return myLList.ElementAt(n);
	}
}
