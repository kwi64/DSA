
using System;

namespace TwoPointers;

internal class LC_125_ValidPalindrome
{

    public static bool Question(string s)
    {
        
        Func<bool>[] solutions = [
            () => {
                
                return false;
            } 
        ]; 

        return solutions[0].Invoke();
    }

    static void Main(string[] args)
    {

        bool test1 = Question("A man, a plan, a canal: Panama");
        bool test2 = Question("race a car");
        bool test3 = Question(" ");

        Console.WriteLine($"{test1} {test2} {test3}");
    }
}