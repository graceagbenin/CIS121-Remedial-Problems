//Grace Ofure Agbenin
// April 1, 2025

using System;
using System.Collections.Generic;


namespace LeetCodeSolutions
{
    public class Needle
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            if (haystack.Length < needle.Length) return -1;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
