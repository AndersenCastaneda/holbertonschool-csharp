/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiply a 2D or 3D vector by a scalar
    /// </summary>
    /// <param name="vector">2D or 3D Vector</param>
    /// <param name="scalar">Scalar</param>
    /// <returns>New Vector, the result of Multiplication</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        int length = vector.Length;
        if (length < 2 || length > 3)
            return new double[] { -1 };

        double[] mul = new double[length];
        for (int i = 0; i < length; i++)
            mul[i] = vector[i] * scalar;

        return mul;
    }
}
