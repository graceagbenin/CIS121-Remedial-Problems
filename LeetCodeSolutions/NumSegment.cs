//Grace Ofure Agbenin
// April 9, 2025

using System;


namespace LeetCodeSolutions
{
    public class NumSegment
    {
        public int CountSegments(string s)
        {
            int count = 0;
            bool inSegment = false;
            foreach (char c in s)
            {
                if (c != ' ' && !inSegment)
                {
                    count++;
                    inSegment = true;
                }
                else if (c == ' ')
                {
                    inSegment = false;
                }
            }
            return count;
        }
    }
}
