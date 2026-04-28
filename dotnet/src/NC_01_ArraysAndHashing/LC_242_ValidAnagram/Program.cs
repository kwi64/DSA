using System;
using System.Collections.Generic;

namespace NC_01_ArraysAndHashing.LC_242_ValidAnagram
{
    internal class Program : IQuestion
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> letters = [];

            foreach(char c in s)
            {
                if(!letters.TryAdd(c, 1))
                {
                    letters[c]++;
                }
            }

            foreach(char c in t)
            {
                if(letters.TryGetValue(c, out int count) && count > 0)
                {
                    letters[c]--;
                }
                else
                {
                    return false;
                }
            }
            
            return true;
        }

        static void Main(string[] args)
        {
            bool test1 = IsAnagram("racecar", "carrace"); // True
            bool test2 = IsAnagram("jar", "jam"); // False
            Console.WriteLine("{0}, {1}", test1, test2);
        }
    }
}
