using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = aQueue.Count;
        Console.WriteLine($"Number of items: {count}");
        if (count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine($"First item: {aQueue.Peek()}");
        bool hasObject = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {hasObject}");
        if (hasObject)
        {
            for (int i = 0; i < count; i++)
            {
                if (aQueue.Peek() == search)
                    i = count;
                aQueue.Dequeue();
            }
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
