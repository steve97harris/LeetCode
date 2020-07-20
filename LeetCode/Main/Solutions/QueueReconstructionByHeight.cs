using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public class QueueReconstructionByHeight
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var reconstructedQueue = new List<int[]>();
            
            // sort by value at index 0 in decreasing order,
            // if two arrays have same index 0 then short by index 1 in increasing order. 
            Array.Sort(people, (a,b) => a[0] != b[0] ? b[0] - a[0] : a[1] - b[1]);

            for (int i = 0; i < people.Length; i++)
            {
                var index = people[i][1];
                reconstructedQueue.Insert(index, people[i]);
            }
            
            return reconstructedQueue.ToArray();
        }
    }
}