using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int i = 0;
        List<int> div = new List<int>();

        try
        {
            for (; i < listLength; i++)
            {
                if (list2[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    div.Add(0);
                }
                else
                    div.Add(list1[i] / list2[i]);
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Out of range");
        }

        return div;
    }
}
