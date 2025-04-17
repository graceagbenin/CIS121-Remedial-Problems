//Written by Grace Ofure Agbenin
// April 16, 2025


using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetCodeSolutions
{
    public class PivotIndex
    {
        public int FindPIndex(int[] nums)
        {
            int Totalsum = nums.Sum();
            int leftsum = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (leftsum==(Totalsum - leftsum - nums[i]))
                {
                    return i;
                }
                leftsum += nums[i];

            }
            return -1;

        }
    }
}
