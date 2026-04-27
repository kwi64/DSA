using System;
using System.Collections.Generic;

namespace _01_ArraysAndHashing.LC_217_ContainsDuplicate;

internal class Program: IQuestion
{

    public static bool ContainsDuplicate(int[] nums)
    {
        return Solution1.ContainsDuplicate(nums);
    }

    static void Main(string[] args)
    {
        bool test1 = ContainsDuplicate([1, 2, 3, 1]);
        bool test2 = ContainsDuplicate([1, 2, 3, 4]);
        bool test3 = ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]);

        Console.WriteLine("{0}, {1}, {2}", test1, test2, test3);
    }
}