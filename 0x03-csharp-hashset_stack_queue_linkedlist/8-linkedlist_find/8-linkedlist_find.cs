using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (myLList == null)
            return -1;

        int index = 0;
        foreach (var item in myLList)
        {
            if (item == value)
                return index;
            index++;
        }

        return -1;
    }
}
