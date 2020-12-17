using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class Operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Get the maximum value in a List
        /// </summary>
        /// <param name="nums">List of Integers</param>
        /// <returns>Maximum Value</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            int length = nums.Count;
            int max = nums[0];

            for (int i = 0; i < length; i++)
                if (nums[i] > max)
                    max = nums[i];

            return max;
        }
    }
}
