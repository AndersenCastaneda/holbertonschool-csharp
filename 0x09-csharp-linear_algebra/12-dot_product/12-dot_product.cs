/// <summary>
/// VectorMath CLass
/// </summary>
class VectorMath
{
    /// <summary>
    /// Gets Dot Product between two vectors
    /// </summary>
    /// <param name="vector1">First vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns>Dot product</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int len1 = vector1.Length, len2 = vector2.Length;
        if (len1 < 2 || len1 > 3 || len2 < 2 || len2 > 3 || len1 != len2)
            return -1.0;

        double dot = 0;
        for (int i = 0; i < len1; i++)
            dot += vector1[i] * vector2[i];

        return dot;
    }
}
