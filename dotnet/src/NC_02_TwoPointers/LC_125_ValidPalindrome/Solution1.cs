using System;
using System.Collections.Generic;
using System.Text;

namespace NC_02_TwoPointers.LC_125_ValidPalindrome
{
    internal class Solution1 : IQuestion
    {
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < s.Length && right > 0 && left < right)
            {


                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                    continue;
                }

                if (char.ToLower(s[left]) == char.ToLower(s[right]))
                {
                    left++;
                    right--;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
