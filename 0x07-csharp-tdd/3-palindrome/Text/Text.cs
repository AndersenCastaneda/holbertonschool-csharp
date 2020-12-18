using System;

namespace Text
{
    /// <summary>
    /// Class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Return true or false if a string is a palindrome
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns>true or false</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null || s.Length == 0)
                return false;

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }

            return true;
        }
    }
}
