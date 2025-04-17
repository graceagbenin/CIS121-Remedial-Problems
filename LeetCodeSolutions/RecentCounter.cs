//Written by Grace Ofure Agbenin
// April 16, 2025


using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetCodeSolutions
{
    public class RecentCounter
    {
        private Queue<int> queue;
        public RecentCounter()
        {
            queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            queue.Enqueue(t);

            while(queue.Peek() < t-3000)
            {
                queue.Dequeue();
            }
            return queue.Count;
        }
    }
}
