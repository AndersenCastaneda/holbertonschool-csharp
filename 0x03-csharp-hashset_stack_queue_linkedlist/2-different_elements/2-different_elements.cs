using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        if (list1 == null || list2 == null)
            return newList;

        int length = list1.Count;
        for (int i = 0; i < length; i++)
        {
            if (!list2.Contains(list1[i]))
                newList.Add(list1[i]);
        }

        length = list2.Count;
        for (int i = 0; i < length; i++)
        {
            if (!list1.Contains(list2[i]))
                newList.Add(list2[i]);
        }

        newList.Sort();
        return newList;
    }
}
