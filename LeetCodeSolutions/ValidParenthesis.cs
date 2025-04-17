//Written by Grace Ofure Agbenin
// April 16, 2025

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LeetCodeSolutions
{
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(') stack.Push(')');
                else if (c == '[') stack.Push(']');
                else if (c == '{') stack.Push('}');
                else if (stack.Count == 0 || stack.Pop() != c) return false;
            }


            return stack.Count == 0;

        }
    }    
}
