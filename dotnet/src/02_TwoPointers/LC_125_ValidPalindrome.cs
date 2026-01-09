
using System;

namespace _02_TwoPointers;

/*
* You should aim for a solution with O(n) time and O(1) space, where n is the length of the input string.
*/

internal class LC_125_ValidPalindrome
{

    public static bool IsPalindrome(string s)
    {
        Func<bool>[] solutions =
        [
            () => {
                int left = 0;
                int right = s.Length - 1;

                while(left < s.Length && right > 0 && left < right) {


                    if(!char.IsLetterOrDigit(s[left])) {
                        left++;
                        continue;
                    }

                    if(!char.IsLetterOrDigit(s[right])) {
                        right--;
                        continue;
                    }

                    if(char.ToLower(s[left]) == char.ToLower(s[right]))
                    {
                        left++;
                        right--;
                        continue;
                    }

                    return false;
                }

                return true;
            }
        ];

        return solutions[0].Invoke();
    }

    static void Main(string[] args)
    {

        bool test1 = IsPalindrome("A man, a plan, a canal: Panama"); // true
        bool test2 = IsPalindrome("race a car"); // false
        bool test3 = IsPalindrome(" "); // true
        bool test4 = IsPalindrome(".,"); // true
        bool test5 = IsPalindrome("0P"); // false


        Console.WriteLine($"Test 1: {test1}");
        Console.WriteLine($"Test 2: {test2}");
        Console.WriteLine($"Test 3: {test3}");
        Console.WriteLine($"Test 4: {test4}");
        Console.WriteLine($"Test 5: {test5}");
    }
}