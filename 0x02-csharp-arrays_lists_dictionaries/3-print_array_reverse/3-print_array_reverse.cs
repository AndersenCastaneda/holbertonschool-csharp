using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int index;

        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        index = array.Length - 1;
        while (index >= 0)
        {
            Console.Write((index != 0) ? $"{array[index]} " : $"{array[index]}\n");
            index--;
        }
    }
}
