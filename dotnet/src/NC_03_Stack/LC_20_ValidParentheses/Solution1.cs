using System;
using System.Collections.Generic;
using System.Text;

namespace NC_03_Stack.LC_20_ValidParentheses
{
    internal class Solution1 : IQuestion
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> pairs = new()
            {
                ['('] = ')',
                ['{'] = '}',
                ['['] = ']',
            };
            Stack<char> brackets = new();

            int i = 0;
            while (i < s.Length)
            {
                if (pairs.ContainsKey(s[i]))
                {
                    // collect and go to next iteration
                    brackets.Push(s[i++]);
                    continue;
                }

                // encountering the first closing bracket
                // if it is not the top/latest opening bracket we collected, then the pair is invalid
                // if the first one is a closing bracket, it means the stack is going to be empty
                if (brackets.Count > 0 && pairs[brackets.Pop()] == s[i])
                {
                    i++;
                    continue;
                }

                return false;
            }

            return brackets.Count == 0;
        }
    }
}
