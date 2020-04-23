using System;
using System.Linq;

namespace LeetCode.Main
{
    public static class DistributeCandiesToPeople
    {
        public static int[] DistributeDeCandies(int candies, int num_people)
        {
            var candyDistribution = new int[num_people];

            int index = 0;
            while (candyDistribution.Sum() < candies)
            {
                candyDistribution[index] = index + 1;
                index++;
            }

            if (candyDistribution.Sum() > candies)
            {
                candyDistribution[num_people - 1] -= candyDistribution.Sum() - candies;
            }


            foreach (var i in candyDistribution)
            {
                Console.WriteLine(i);
            }
            return candyDistribution;
        }
    }
}