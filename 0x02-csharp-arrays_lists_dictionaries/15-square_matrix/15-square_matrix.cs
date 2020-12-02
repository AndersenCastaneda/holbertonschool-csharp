using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] newMatrix = new int[,] { };

        if (myMatrix == null || myMatrix.Length == 0)
            return newMatrix;

        int height = myMatrix.GetLength(0);
        int width = myMatrix.GetLength(1);

        newMatrix = new int[height, width];
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
                newMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
        }

        return newMatrix;
    }
}
