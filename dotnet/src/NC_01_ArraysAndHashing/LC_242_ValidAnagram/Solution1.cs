using System;
using System.Collections.Generic;

namespace NC_01_ArraysAndHashing.LC_242_ValidAnagram
{
    internal class Solution1 : IQuestion
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> letters = [];

            foreach (char c in s)
            {
                if (!letters.TryAdd(c, 1))
                {
                    letters[c]++;
                }
            }

            foreach (char c in t)
            {
                if (letters.TryGetValue(c, out int count) && count > 0)
                {
                    letters[c]--;
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
