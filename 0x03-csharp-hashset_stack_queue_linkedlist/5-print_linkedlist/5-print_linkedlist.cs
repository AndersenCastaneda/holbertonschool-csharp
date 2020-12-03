using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        int length = (size < 0) ? 0 : size;
        LinkedList<int> myList = new LinkedList<int>();

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"{i}");
            myList.AddLast(i);
        }

        return myList;
    }
}
