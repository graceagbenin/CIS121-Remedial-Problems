//Written by Grace Ofure Agbenin
// April 22, 2025

using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetCodeSolutions
{
    public class StringReverse
    {
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }

            
        }
    }
}
