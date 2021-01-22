using System;

/// <summary>
/// Class to calculate vector maths
/// </summary>
class VectorMath
{
    /// <summary>
    /// calculates the cross product of two 3D vectors and returns the resulting vector
    /// </summary>
    /// <return>
    /// the result or if either vector is not a 3D vector, return a vector containing -1
    /// </return>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] num = new double[3];

        if (vector1.Length == 3 && vector2.Length == 3)
        {
            num[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
            num[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
            num[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
            return num;
        }
        return new double[] { -1 };
    }
}
