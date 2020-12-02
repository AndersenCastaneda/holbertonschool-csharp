using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list = new List<int>();

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
            Console.WriteLine();

        for (int i = 0; i < size; i++)
        {
            Console.Write((i != size - 1) ? $"{i} " : $"{i}\n");
            list.Add(i);
        }
        
        return list;
    }
}
