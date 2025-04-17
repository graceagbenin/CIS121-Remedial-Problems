//Written by Grace Ofure Agbenin
// April 16, 2025


using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetCodeSolutions
{
    public class StudentLunch
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int[] counts = new int[2];
            foreach (int student in students) counts[student]++;

            for(int i = 0; i < sandwiches.Length; i++)
            {
                if (counts[sandwiches[i]] == 0)
                    return counts[0] + counts[1];
                counts[sandwiches[i]]--;
            }
            return 0;
        }
    }
}
