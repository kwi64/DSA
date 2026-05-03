using System;
using System.Collections.Generic;

namespace NC_03_Stack.LC_20_ValidParentheses;

internal class Program: IQuestion
{
    /*
    You should aim for a solution with O(n) time and O(n) space, where n is the length of the given string.
    */
    public static bool IsValid(string s)
    {
        return Solution3.IsValid(s);
    }

    static void Main(string[] args)
    {
        bool test1 = IsValid("()");
        bool test2 = IsValid("()[]{}");
        bool test3 = IsValid("(]");
        bool test4 = IsValid("([])");
        bool test5 = IsValid("([)]");
        bool test6 = IsValid("[");
        bool test7 = IsValid("]");

        Console.WriteLine($"Test1 Expected True; Actual {test1}");
        Console.WriteLine($"Test2 Expected True; Actual {test2}");
        Console.WriteLine($"Test3 Expected False; Actual {test3}");
        Console.WriteLine($"Test4 Expected True; Actual {test4}");
        Console.WriteLine($"Test5 Expected False; Actual {test5}");
        Console.WriteLine($"Test6 Expected False; Actual {test6}");
        Console.WriteLine($"Test7 Expected False; Actual {test7}");
    }
}