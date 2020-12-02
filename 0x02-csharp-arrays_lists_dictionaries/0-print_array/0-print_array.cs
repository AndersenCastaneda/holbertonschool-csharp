using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] arr;

        if (size <= 0)
        {
            Console.WriteLine((size == 0) ? "" : "Size cannot be negative");
            return new int[0];
        }

        arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = i;
            Console.Write((i != size - 1) ? $"{i} " : $"{i}\n");
        }

        return arr;
    }
}
