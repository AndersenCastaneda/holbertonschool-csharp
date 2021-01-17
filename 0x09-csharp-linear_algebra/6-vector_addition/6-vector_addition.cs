/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two vectors
    /// </summary>
    /// <param name="vector1">First Vector</param>
    /// <param name="vector2">Second Vector</param>
    /// <returns>The sum between vector1 and vector2</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int len1 = vector1.Length, len2 = vector2.Length;

        if (len1 < 2 || len1 > 3 || len2 < 2 || len2 > 3 || len1 != len2)
            return new double[] { -1 };

        double[] sum = new double[len1];
        for (int i = 0; i < len1; i++)
            sum[i] = vector1[i] + vector2[i];

        return sum;
    }
}
