using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ArraysAndHashing.LC_217_ContainsDuplicate
{
    internal class Solution1 : IQuestion
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> unique = [];
            foreach(int n in nums)
            {
                if (!unique.Add(n)) return true;
            }
            return false;
        }
    }
}
