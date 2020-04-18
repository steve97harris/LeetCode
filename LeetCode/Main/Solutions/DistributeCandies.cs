using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class DistributeCandies
    {
        public static int DistributeDeCandies(int[] candies)
        {
            var bro = new List<int>();
            var sis = new List<int>();

            var candyLength = candies.Length;
            for (int i = 0; i < candyLength; i++)
            {
                if (i < candyLength/2)
                    bro.Add(candies[i]);
                else
                    sis.Add(candies[i]);
            }

            return sis.Count;
        }
    }
}