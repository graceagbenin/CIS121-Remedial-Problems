//Grace Ofure Agbenin
// April 1, 2025

using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class MergeTwo
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1, k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
