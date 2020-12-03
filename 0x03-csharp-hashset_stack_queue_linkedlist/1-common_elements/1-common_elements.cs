using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        if (list1 == null || list2 == null)
            return newList;

        list1.Sort();
        foreach (var item in list1)
        {
            if (list2.Contains(item))
                newList.Add(item);
        }

        return newList;
    }
}
