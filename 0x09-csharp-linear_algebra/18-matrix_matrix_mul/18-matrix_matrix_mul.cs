using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices
    /// </summary>
    /// <return>
    /// a new Matrix
    /// </return>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] newMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            double num;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    num = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                        num += matrix1[i, k] * matrix2[k, j];

                    newMatrix[i, j] = Math.Round(num, 2);
                }
            }
            return newMatrix;
        }
        return new double[,] { { -1 } };
    }
}
