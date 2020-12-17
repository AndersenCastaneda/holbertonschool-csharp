using System;

namespace MyMath
{
    /// <summary>
    /// Matrix Class
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divide all elemtens in a two dimensions array
        /// </summary>
        /// <param name="matrix">Two dimensions array</param>
        /// <param name="num">Divider</param>
        /// <returns>Each element of the array divide by num</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);
            int[,] res = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                    res[i, j] = matrix[i, j] / num;
            }

            return res;
        }
    }
}
