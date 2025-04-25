//Written by Grace Ofure Agbenin
// April 22, 2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace LeetCodeSolutions
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
           while(n != 1 && n!= 4)
            {
                n = SumOfSquares(n);
            }
           return n == 1; 
        }

        public int SumOfSquares(int num)
        {
            int sum = 0;
            while (num >0)
            {
                int digit = num % 10;
                sum += digit * digit;
                num /= 10;
            }
            return sum;
        }
    }
}
