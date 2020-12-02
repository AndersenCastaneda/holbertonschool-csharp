using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int bigger = Int32.MinValue, length;

        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        length = myList.Count;
        for (int i = 0; i < length; i++)
        {
            if (myList[i] > bigger)
                bigger = myList[i];
        }

        return bigger;
    }
}
