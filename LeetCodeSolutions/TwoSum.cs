//Grace Ofure Agbenin
// April 1, 2025

using System;
using System.Collections.Generic;


namespace LeetCodeSolutions
{
    public class TwoSum
    {
        public int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }
                numDict[nums[i]] = i;
            }
            return new int[0];
        }
    }
}