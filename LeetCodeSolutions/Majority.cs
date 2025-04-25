//Written by Grace Ofure Agbenin
// April 22, 2025

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;


namespace LeetCodeSolutions
{
    public class Majority
    {
        public int MajorityElement(int[] num)
        {
            int majority = num[0], votes = 1;
            for(int i =1; i< num.Length; i++)
            {
                if (votes == 0)
                {
                    majority = num[i];
                    votes++;
                }
                else if (majority == num[i])
                {
                    votes++;
                }
                else
                    votes--;
            }
            return majority;
        } 
    }
}
