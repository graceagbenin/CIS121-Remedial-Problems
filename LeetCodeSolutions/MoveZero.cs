//Written by Grace Ofure Agbenin
// April 22, 2025

using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetCodeSolutions
{
    public class MoveZero
    {
        public void MoveZeroes(int[] nums)
        {
            int j = 0;
            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j++] = nums[i];
                }

            }
            for(int i = j;  i < nums.Length; i++)
            {
                nums[i] = 0;
            }



        }   
    }
}
