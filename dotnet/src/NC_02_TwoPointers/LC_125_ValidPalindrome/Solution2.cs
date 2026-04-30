using System;
using System.Text.RegularExpressions;

namespace NC_02_TwoPointers.LC_125_ValidPalindrome
{
    internal partial class Solution2 : IQuestion
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower(); // cleanup
            if (s.Length == 0) return false;

            // raca e acar
            int l = 0;
            int r = s.Length - 1;
            while (l <= r)
            {
                if (!Regex.IsMatch(s[l].ToString(), @"[a-z0-9]"))
                {
                    l++;
                    continue;
                }

                if(!Regex.IsMatch(s[r].ToString(), @"[a-z0-9]"))
                {
                    r--;
                    continue;
                }

                if (s[l] == s[r])
                {
                    l++;
                    r--;
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
