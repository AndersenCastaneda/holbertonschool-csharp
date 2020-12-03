using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || myLList.Count == 0 || index < 0 || index >= myLList.Count)
            return;

        LinkedListNode<int> node = myLList.First;
        for (int i = 0; node != null; i++)
        {
            if (i == index)
                myLList.Remove(node.Value);

            node = node.Next;
        }
    }
}
