using System;
using System.Collections.Generic;

namespace NC_01_ArraysAndHashing.LC_242_ValidAnagram
{
    internal class Program : IQuestion
    {
        public static bool IsAnagram(string s, string t)
        {
            return Solution2.IsAnagram(s, t);
        }

        static void Main(string[] args)
        {
            bool test1 = IsAnagram("racecar", "carrace"); // True
            bool test2 = IsAnagram("jar", "jam"); // False
            Console.WriteLine("{0}, {1}", test1, test2);
        }
    }
}
