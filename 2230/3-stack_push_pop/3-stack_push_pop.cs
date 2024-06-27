using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = aStack.Count;
        Console.WriteLine($"Number of items: {count}");
        if (count == 0)
            System.Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aStack.Peek()}");
        bool hasObject = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {hasObject}");
        if (hasObject)
        {
            for (int i = 0; i < count; i++)
            {
                if (aStack.Peek() == search)
                    i = count;
                aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
