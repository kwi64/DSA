using System;
using System.Collections.Generic;
using System.Text;

namespace NC_02_TwoPointers.LC_167_TwoSum2Sorted
{
    internal class Solution1 : IQuestion
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int l = 0;
            int r = numbers.Length - 1;
            while (l < r)
            {
                int sum = numbers[l] + numbers[r];
                if (sum > target)
                {
                    r--;
                    continue;
                }
                else if (sum < target)
                {
                    l++;
                    continue;
                }
                else
                {
                    return [++l, ++r]; // returning positions as 1 based indexes
                }
            }

            return [];
        }
    }
}
