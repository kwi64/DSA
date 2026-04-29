using System;
using System.Collections.Generic;
using System.Text;

namespace NC_01_ArraysAndHashing.LC_242_ValidAnagram
{
    internal class Solution2 : IQuestion
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> counts = [];

            for (int i = 0; i < s.Length; i++)
            {
                if(!counts.TryAdd(s[i], 1))
                {
                    // letter exists already, incrementing the count
                    counts[s[i]]++;
                }

                if (!counts.TryAdd(t[i], -1))
                {
                    // letter exists already, decrementing the count
                    counts[t[i]]--;
                }
            }

            foreach(int v in counts.Values)
            {
                if (v != 0) return false;
            }

            return true;
        }
    }
}
