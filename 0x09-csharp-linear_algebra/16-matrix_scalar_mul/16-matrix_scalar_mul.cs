using System;

/// <summary>
/// MatrixMath Class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiply a Matrix by a scalar
    /// </summary>
    /// <param name="matrix">Matrix to multiply</param>
    /// <param name="scalar">Scalar</param>
    /// <returns>New Matrix</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows1 = matrix.GetLength(0), cols1 = matrix.GetLength(1);

        if (cols1 < 2 || cols1 > 3 || rows1 < 2 || rows1 > 3)
            return new double[,] { { -1 } };

        double[,] mul = new double[rows1, cols1];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
                mul[i, j] = matrix[i, j] * scalar;
        }

        return mul;
    }
}
