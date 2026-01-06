
using System;
using System.Collections.Generic;

namespace ArraysAndHashing;

internal class LC_217_ContainsDuplicate
{

    public static bool ContainsDuplicate(int[] nums)
    {
        var solutions = new Func<bool>[]
        {
            () => {
                HashSet<int> values = [];

                for(int i = 0; i < nums.Length; i++)
                {
                    if(!values.Add(nums[i])) return true;
                }

                return false;
            }
        };

        return solutions[0].Invoke();
    }

    static void Main(string[] args)
    {
        bool test1 = ContainsDuplicate([1, 2, 3, 1]);
        bool test2 = ContainsDuplicate([1, 2, 3, 4]);
        bool test3 = ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]);

        Console.WriteLine("{0}, {1}, {2}", test1, test2, test3);
    }
}