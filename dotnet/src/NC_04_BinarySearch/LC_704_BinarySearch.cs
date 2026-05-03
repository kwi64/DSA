using System;

namespace NC_04_BinarySearch;

/*
    You should aim for a solution with O(logn) time and O(1) space, where n is the size of the input array.
*/

class LC_704_BinarySearch
{
    public static int Search(int[] nums, int target)
    {

        Func<int>[] solutions = [

            () => {

                int left = 0;
                int right = nums.Length;
                int pivot = (right - left) / 2;

                while(left < right)
                {

                }

                return 0;
            }
        ];

        return solutions[0].Invoke();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}