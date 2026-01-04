using System;

namespace Stack;

internal class LC_20_ValidParentheses
{
    public static bool IsValid(string s)
    {
        return false;
    }

    static void Main(string[] args)
    {
        bool test1 = IsValid("()");
        bool test2 = IsValid("()[]{}");
        bool test3 = IsValid("(]");
        bool test4 = IsValid("([])");
        bool test5 = IsValid("([)]");

        Console.WriteLine($"Test1 {test1}");
        Console.WriteLine($"Test2 {test2}");
        Console.WriteLine($"Test3 {test3}");
        Console.WriteLine($"Test4 {test4}");
        Console.WriteLine($"Test5 {test5}");
    }   
}