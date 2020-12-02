using System;

class Program
{
    static void Main(string[] args)
    {
        int height = 3;
        int width;
        int[][] jaggedArray = new int[3][] {
            new int[] { 0, 1, 2, 3 },
            new int[] { 0, 1, 2, 3, 4, 5, 6 },
            new int[] {0, 1 },
        };

        for (int i = 0; i < height; i++)
        {
            width = jaggedArray[i].Length;
            for (int j = 0; j < width; j++)
                Console.Write((j != width - 1) ? $"{j} " : $"{j}\n");
        }
    }
}
