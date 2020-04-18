using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class DistributeCandies
    {
        public static int DistributeDeCandies(int[] candies)
        {
            var sis = new List<int>();

            for (int i = 0; i < candies.Length - 1; i++)
            {
                if (candies[i] != candies[i + 1] && sis.Count <= candies.Length / 2)
                    sis.Add(candies[i]);
            }

            foreach (var i in sis)
            {
                Console.WriteLine(i);
            }

            var result = sis.Distinct().ToArray();

            //Console.WriteLine(result.Length);
            return result.Length;
        }
    }
}