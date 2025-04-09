//Grace Ofure Agbenin
// April 9, 2025


using System;
using System.Collections.Generic;


namespace LeetCodeSolutions
{
    public class UniqueChar
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (freq.ContainsKey(c)) freq[c]++;
                else freq[c] = 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i]] == 1) return i;
            }
            return -1;
        }
    }
}
