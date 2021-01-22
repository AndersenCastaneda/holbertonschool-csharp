using System;

/// <summary>
/// Class to calculate matrix maths
/// </summary>
class MatrixMath
{
    /// <summary>
    /// calculates the determinant of a matrix
    /// </summary>
    /// <return>
    /// a new Matrix
    /// </return>
    public static double Determinant(double[,] matrix)
    {
        double num;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            num = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return Math.Round(num, 2);
        }
        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            num = (matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1])));
            num -= (matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0])));
            num += (matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0])));
            return Math.Round(num, 2);
        }
        return -1;
    }
}