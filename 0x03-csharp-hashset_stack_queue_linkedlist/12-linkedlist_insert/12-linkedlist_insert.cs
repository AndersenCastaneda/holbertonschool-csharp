using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(0);

        if (myLList == null || myLList.Count == 0)
            return node;

        node = myLList.First;
        while (node != null)
        {
            if (node.Value > n)
            {
                myLList.AddBefore(node, n);
                node = node.Previous;
                break;
            }
            node = node.Next;
        }

        return node;
    }
}
