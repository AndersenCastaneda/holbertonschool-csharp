using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        int length1 = list1.Count;
        int length2 = list2.Count;
        List<int> newList = new List<int>();

        if (list1 == null || length1 == 0 || list2 == null || length2 == 0)
            return newList;

        for (int i = 0; i < length1; i++)
        {
            for (int j = 0; j < length2; j++)
            {
                if (list1[i] == list2[j])
                    newList.Add(list1[i]);
            }
        }

        return newList;
    }
}
