using System;

namespace NC_02_TwoPointers.LC_167_TwoSum2Sorted
{
    internal class Program : IQuestion
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            return Solution1.TwoSum(numbers, target);
        }

        static void Main(string[] _)
        {
            int[] test1 = TwoSum([1, 2, 3, 4], 3); // [1, 2]

            Console.WriteLine("{0}", test1.PrintOut());
        }
    }
}
