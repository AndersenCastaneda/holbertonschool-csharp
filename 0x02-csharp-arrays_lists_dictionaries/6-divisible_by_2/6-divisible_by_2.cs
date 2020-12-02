using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> boolList = new List<bool>();

        int length = myList.Count;
        for (int i = 0; i < length; i++)
            boolList.Add((myList[i] % 2 == 0));

        return boolList;
    }
}
