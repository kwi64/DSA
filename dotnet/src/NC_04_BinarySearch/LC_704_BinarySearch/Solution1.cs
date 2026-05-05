using System;
using System.Collections.Generic;
using System.Text;

namespace NC_04_BinarySearch.LC_704_BinarySearch
{
    internal class Solution1 : IQuestion
    {
        public static int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;
            int pivot = (left + right) / 2;

            do
            {
                if (nums[left] == target)
                {
                    return left;
                }


                if (nums[pivot] == target)
                {
                    return pivot;
                }

                if (nums[right] == target)
                {
                    return right;
                }

                // at this point, target is still not found
                if (target > nums[pivot])
                {
                    left = pivot;
                }
                else
                {
                    right = pivot;
                }

                pivot = (left + right) / 2;

            } while (pivot > left && pivot < right);

            return -1;
        }
    }
}
