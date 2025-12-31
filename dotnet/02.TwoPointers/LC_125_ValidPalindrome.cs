
using System;

namespace TwoPointers;

internal class LC_125_ValidPalindrome
{

    public static bool Question(string s)
    {
        Func<bool>[] solutions = [
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

        bool test1 = Question("A man, a plan, a canal: Panama"); // true
                                                                 // bool test2 = Question("race a car"); // false
                                                                 // bool test3 = Question(" ");
                                                                 // bool test4 = Question(".,");
                                                                 // bool test5 = Question("0P");


        // Console.WriteLine($"Is Letter: {char.IsLetter(' ')}");
        Console.WriteLine($"Test 1: {test1}");
        // Console.WriteLine($"Test 2: {test2}");
        // Console.WriteLine($"Test 3: {test3}");
        // Console.WriteLine($"Test 4: {test4}");
        // Console.WriteLine($"Test 5: {test5}");
    }
}