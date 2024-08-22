using System.Collections.Generic;
using System.Linq;

class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int index = myLList.TakeWhile(node => value != node).Count();
		return index == myLList.Count ? -1 : index;
	}
}
