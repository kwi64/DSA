using System;
using System.Collections.Generic;
using System.Text;

namespace NC_03_Stack.LC_20_ValidParentheses
{
    internal class Solution2 : IQuestion
    {
        public static bool IsValid(string s)
        {
            Stack<char> brackets = [];

            foreach (char bracket in s)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    // its an opening brackt
                    brackets.Push(bracket);
                }
                else
                {
                    if (brackets.Count == 0) return false;
                    char topOpeningBracket = brackets.Pop();
                    if (bracket == ')' && topOpeningBracket != '(') return false;
                    if (bracket == '}' && topOpeningBracket != '{') return false;
                    if (bracket == ']' && topOpeningBracket != '[') return false;
                }
            }

            return brackets.Count == 0;
        }
    }
}
