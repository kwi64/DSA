using System;
using System.Collections.Generic;
using System.Text;

namespace NC_03_Stack.LC_20_ValidParentheses
{
    internal class Solution3 : IQuestion
    {
        // Contents: '(', ')', '{', '}', '[' and ']'
        // Input: s = "([{}])"
        public static bool IsValid(string s)
        {
            Stack<char> openings = [];
            Dictionary<char, char> pairs = new() { 
                ['('] = ')',
                ['{'] = '}',
                ['['] = ']',
            };

            int i = 0;
            while(i < s.Length)
            {
                // putting opening brackets
                if (pairs.ContainsKey(s[i]))
                {
                    openings.Push(s[i]);
                }

                // encountering a closing bracket
                if (pairs.ContainsValue(s[i]))
                {
                    if(!openings.TryPop(out char opening) || !pairs.TryGetValue(opening, out char closing) || s[i] != closing)
                    {
                        return false;
                    }
                }

                i++;
            }

            return openings.Count == 0;
        }
    }
}
