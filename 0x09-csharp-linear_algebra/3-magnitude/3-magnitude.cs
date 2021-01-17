using System;

/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>Gets the magnitude of 2D or 3D vector</summary>
    /// <param name="vector">Vector to calculate</param>
    /// <returns>The magnitude of a 2D or 3D vector</returns>
    public static double Magnitude(double[] vector)
    {
        int length = vector.Length;
        if (length < 2 || length > 3)
            return -1;

        double magnitude = 0;
        for (int i = 0; i < length; i++)
            magnitude += Math.Pow(vector[i], 2);

        magnitude = Math.Sqrt(magnitude);
        magnitude = Math.Round(magnitude, 2);

        return magnitude;
    }
}
