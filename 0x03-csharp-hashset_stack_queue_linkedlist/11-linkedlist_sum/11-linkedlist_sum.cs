using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        if (myLList == null || myLList.Count == 0)
            return sum;

        foreach (var item in myLList)
            sum += item;

        return sum;
    }
}
