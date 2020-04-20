using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MinimumSubsequenceInNonIncreasingOrder
    {
        public static IList<int> MinSubsequence(int[] nums)
        {
            var minSubset = new List<int>();
            var remainingNums = new List<int>();

            foreach (var i in nums)
            {
                remainingNums.Add(i);
            }
            
            while (minSubset.Sum() <= remainingNums.Sum())
            {
                var curMax = remainingNums.Max();
                minSubset.Add(curMax);
                remainingNums.Remove(curMax);
            }

            foreach (var i in minSubset)
            {
                Console.WriteLine(i);
            }

            return minSubset;
        }
    }
}