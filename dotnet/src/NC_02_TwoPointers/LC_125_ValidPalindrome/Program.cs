using System;

namespace NC_02_TwoPointers.LC_125_ValidPalindrome;

/*
* You should aim for a solution with O(n) time and O(1) space, where n is the length of the input string.
*/

internal class Program: IQuestion
{

    public static bool IsPalindrome(string s)
    {
        return Solution2.IsPalindrome(s);
    }

    static void Main(string[] args)
    {

        bool test1 = IsPalindrome("A man, a plan, a canal: Panama"); // true
        bool test2 = IsPalindrome("race a car"); // false
        bool test3 = IsPalindrome(" "); // true
        bool test4 = IsPalindrome(".,"); // true
        bool test5 = IsPalindrome("0P"); // false
        bool test6 = IsPalindrome("Was it a car or a cat I saw?"); // true


        Console.WriteLine($"Test 1: {test1}");
        Console.WriteLine($"Test 2: {test2}");
        Console.WriteLine($"Test 3: {test3}");
        Console.WriteLine($"Test 4: {test4}");
        Console.WriteLine($"Test 5: {test5}");
        Console.WriteLine($"Test 6: {test6}");
    }
}