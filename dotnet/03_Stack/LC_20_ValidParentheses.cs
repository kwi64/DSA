using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace _03_Stack;
internal class LC_20_ValidParentheses
{
    public static bool IsValid(string s)
    {
        List<Func<bool>> solutions = [
            () => {
                Dictionary<char, char> pairs = new()
                {
                    ['('] = ')',
                    ['{'] = '}',
                    ['['] = ']',
                };
                Stack<char> brackets = new();
                
                int i = 0;
                while(i < s.Length)
                {
                    if(pairs.ContainsKey(s[i]))
                    {
                        // collect and go to next iteration
                        brackets.Push(s[i++]); 
                        continue;
                    }

                    // encountering the first closing bracket
                    // if it is not the top/latest opening bracket we collected, then the pair is invalid
                    // if the first one is a closing bracket, it means the stack is going to be empty
                    if(brackets.Count > 0 && pairs[brackets.Pop()] == s[i])
                    {
                        i++;
                        continue;
                    }
                    
                    return false;
                }

                return brackets.Count == 0;
            }
        ];

        return solutions[0].Invoke();
    }

    static void Main(string[] args)
    {
        bool test1 = IsValid("()");
        bool test2 = IsValid("()[]{}");
        bool test3 = IsValid("(]");
        bool test4 = IsValid("([])");
        bool test5 = IsValid("([)]");
        bool test6 = IsValid("[");
        bool test7 = IsValid("]");

        Console.WriteLine($"Test1 Expected True; Actual {test1}");
        Console.WriteLine($"Test2 Expected True; Actual {test2}");
        Console.WriteLine($"Test3 Expected False; Actual {test3}");
        Console.WriteLine($"Test4 Expected True; Actual {test4}");
        Console.WriteLine($"Test5 Expected False; Actual {test5}");
        Console.WriteLine($"Test6 Expected False; Actual {test6}");
        Console.WriteLine($"Test7 Expected False; Actual {test7}");
    }   
}