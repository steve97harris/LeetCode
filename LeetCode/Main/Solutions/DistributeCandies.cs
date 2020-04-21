using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class DistributeCandies
    {
        public static int DistributeDeCandies(int[] candies)
        {
            var distinctCandies = candies.Distinct().ToList();
            var leftOverCandies = candies.ToList();
            
            foreach (var candy in distinctCandies)
            {
                leftOverCandies.Remove(candy);
            }
            
            if (distinctCandies.Count >= candies.Length / 2)
            {
                distinctCandies.RemoveRange(0, distinctCandies.Count - candies.Length/2);
            }
            else
            {
                for (int i = 0; i < candies.Length/2 - distinctCandies.Count; i++)
                {
                    distinctCandies.Add(leftOverCandies[i]);
                }
            }

            var result = distinctCandies.Distinct().ToArray();
            return result.Length;
        }
    }
}