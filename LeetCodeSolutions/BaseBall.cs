//Written by Grace Ofure Agbenin
// April 16, 2025


using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetCodeSolutions
{
    public class BaseBall
    {
        public int CalPoints(string[] operations)
        {
            Stack<int> stack = new Stack<int>();
            foreach (string operation in operations)
            {
                if (operation == "+")
                {
                    stack.Push(stack.ElementAt(0) + stack.ElementAt(1));
                }
                else if (operation == "D")
                {
                    stack.Push(stack.Peek() * 2);
                }
                else if (operation == "C")
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(int.Parse(operation));
                }
            }
            return stack.Sum();


        }
    }
}
