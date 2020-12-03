using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack == null)
            aStack = new Stack<string>();

        Console.WriteLine($"Number of items: {aStack.Count}");
        Console.WriteLine((aStack.Count == 0) ? "Stack is empty" : $"Top item: {aStack.Peek()}");
        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

        while (aStack.Contains(search))
            aStack.Pop();

        if (newItem != null)
            aStack.Push(newItem);

        return aStack;
    }
}
