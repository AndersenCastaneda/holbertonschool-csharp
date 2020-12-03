using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        if (myLList == null)
            myLList = new LinkedList<int>();

        LinkedListNode<int> myLListNode = myLList.AddFirst(n);
        return myLListNode;
    }
}
