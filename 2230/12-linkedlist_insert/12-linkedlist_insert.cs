using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> newNode = new LinkedListNode<int>(n);
		foreach (int value in myLList)
		{
			if (value > n)
			{
				myLList.AddBefore(myLList.Find(value), newNode);
				break;
			}
		}
		if (!myLList.Contains(n))
			myLList.AddLast(newNode);
		return newNode;
	}
}
