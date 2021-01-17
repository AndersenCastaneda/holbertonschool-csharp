using System;

/// <summary>
/// MatrixMath Class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two Matrix
    /// </summary>
    /// <param name="matrix1">First matrix</param>
    /// <param name="matrix2">Second matrix</param>
    /// <returns>New matrix</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0), cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0), cols2 = matrix2.GetLength(1);

        if (cols1 < 2 || cols1 > 3 || cols2 < 2 || cols2 > 3 ||
            rows1 < 2 || rows1 > 3 || rows2 < 2 || rows2 > 3 ||
            cols1 != cols2 || rows1 != rows2)
            return new double[,] { { -1 } };

        double[,] sum = new double[rows1, cols1];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
        }

        return sum;
    }
}
