//Grace Ofure Agbenin
// April 9, 2025

using System;

namespace LeetCodeSolutions
{
    public class FindDiff
    {
        public char FindTheDifference(string s, string t)
        {
            char result = '\0';
            foreach (char c in s) result ^= c;
            foreach (char c in t) result ^= c;
            return result;
        }
    }
}
