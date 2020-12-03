using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack == null)
            return aStack;

        int count = aStack.Count;
        Console.WriteLine($"Number of items: {count}");
        Console.WriteLine((count == 0) ? "Stack is empty" : $"Top item: {aStack.Peek()}");

        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");
        bool isRemoved = false;        
        while (!isRemoved)
        {
            isRemoved = (aStack.Peek() == search);
            aStack.Pop();
        }

        aStack.Push(newItem);
        return aStack;
    }
}
