//Grace Ofure Agbenin
// April 9, 2025

using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class MaxBallons
    {
        public int MaxNumberOfBalloons(string text)
        {
            int b = 0, a = 0, l = 0, o = 0, n = 0;
            foreach (char c in text)
            {
                switch (c)
                {
                    case 'b': b++; break;
                    case 'a': a++; break;
                    case 'l': l++; break;
                    case 'o': o++; break;
                    case 'n': n++; break;
                }
            }
            return Math.Min(Math.Min(Math.Min(b, a), Math.Min(l / 2, o / 2)), n);
        }
    }
}
