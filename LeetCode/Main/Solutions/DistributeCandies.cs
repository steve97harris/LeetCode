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

            var distinctCandies = candies.Distinct().ToArray();
            
            for (int i = 0; i < candies.Length/2; i++) 
            { 
                if (sis.Count <= candies.Length/2) 
                    sis.Add(distinctCandies[i]);
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