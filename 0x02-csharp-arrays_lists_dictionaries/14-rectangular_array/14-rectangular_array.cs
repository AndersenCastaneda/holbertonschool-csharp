using System;

class Program
{
    static void Main(string[] args)
    {
        int length  = 5;
        int[,] twoDimArray = new int[length, length];
        twoDimArray[2, 2] = 1;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write((j != length - 1) ?
                    $"{twoDimArray[i, j]} " : $"{twoDimArray[i, j]}\n");
            }
        }
    }
}
