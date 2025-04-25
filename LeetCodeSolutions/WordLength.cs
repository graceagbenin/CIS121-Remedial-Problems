//Written by Grace Ofure Agbenin
// April 22, 2025


using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace LeetCodeSolutions
{
    public class WordLength
    {
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        return count;
                    }
                }
            }
            return count;



            
            
        }
    }
}
