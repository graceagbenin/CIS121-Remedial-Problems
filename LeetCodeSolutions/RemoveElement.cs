//Grace Ofure Agbenin
// April 1, 2025

using System;
using System.Collections.Generic;


namespace LeetCodeSolutions
{
    public class RemoveElement
    {
        public int RemoveVal (int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }

}
