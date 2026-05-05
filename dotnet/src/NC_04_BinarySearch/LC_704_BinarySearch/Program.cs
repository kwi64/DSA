using System;

namespace NC_04_BinarySearch.LC_704_BinarySearch;

/*
    You should aim for a solution with O(logn) time and O(1) space, where n is the size of the input array.
*/

internal class Program : IQuestion
{
    public static int Search(int[] nums, int target)
    {

        return Solution1.Search(nums, target);
    }

    static void Main(string[] args)
    {
        int test1 = Search([-1, 0, 2, 4, 6, 8], 4);
        int test2 = Search([-1, 0, 2, 4, 6, 8], 3);


        Console.WriteLine("Test1 expected 3; actual: {0}", test1);
        Console.WriteLine("Test1 expected -1; actual: {0}", test2);
    }
}