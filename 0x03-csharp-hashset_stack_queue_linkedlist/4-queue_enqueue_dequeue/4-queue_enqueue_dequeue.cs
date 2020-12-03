using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue == null)
            aQueue = new Queue<string>();

        Console.WriteLine($"Number of items: {aQueue.Count}");
        Console.WriteLine((aQueue.Count == 0) ? "Queue is empty" : $"First item: {aQueue.Peek()}");

        if (newItem != null)
            aQueue.Enqueue(newItem);

        Console.WriteLine($"Stack contains \"{search}\": {aQueue.Contains(search)}");
        while (aQueue.Contains(search))
            aQueue.Dequeue();

        return aQueue;
    }
}
