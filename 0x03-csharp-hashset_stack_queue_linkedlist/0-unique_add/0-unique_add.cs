using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        if (myList == null || myList.Count == 0)
            return 0;

        List<int> newList = myList.Distinct().ToList();
        int length = newList.Count;
        for (int i = 0; i < length; i++)
            sum += newList[i];

        return sum;
    }
}
