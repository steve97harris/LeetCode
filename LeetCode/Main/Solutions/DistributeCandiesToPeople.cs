using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class DistributeCandiesToPeople
    {
        public static int[] DistributeDeCandies(int candies, int num_people)
        {
            var candyDistribution = new List<int>();

            int index = 0;
            while (candyDistribution.Sum() <= candies)
            {
                if (candyDistribution.Count < num_people)
                {
                    candyDistribution.Add(index + 1);
                }
                else
                {
                    break;
                }
                index++;
            }

            while (candyDistribution.Sum() <= candies)
            {
                Loop(candyDistribution, candies);
            }

            if (candyDistribution.Sum() > candies)
            {
                candyDistribution[num_people - 1] -= candyDistribution.Sum() - candies;
            }


            foreach (var i in candyDistribution)
            {
                Console.WriteLine(i);
            }
            return candyDistribution.ToArray();
        }

        private static void Loop(IList<int> candyDistribution, int candies)
        {
            for (int i = 0; i < candyDistribution.Count; i++)
            {
                candyDistribution[i] += i + 1;
                if (candyDistribution.Sum() == candies)
                    break;
            }
        }
    }
}