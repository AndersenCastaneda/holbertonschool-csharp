using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] newMatrix;
        int height = myMatrix.GetLength(0);
        int width = myMatrix.GetLength(1);

        if (myMatrix == null || height == 0 || width == 0)
            return myMatrix;


        newMatrix = new int[height, width];
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
                newMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
        }

        return newMatrix;
    }
}
