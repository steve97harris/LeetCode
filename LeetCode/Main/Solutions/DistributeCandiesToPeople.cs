using System;
using System.Linq;

namespace LeetCode.Main
{
    public static class DistributeCandiesToPeople
    {
        public static int[] DistributeDeCandies(int candies, int num_people)
        {
            var candyDistribution = new int[num_people];

            
            for (int i = 0; i < candyDistribution.Length - 1; i++)
            {
                candyDistribution[i] = i + 1;
            }
            candyDistribution[num_people] = candies - candyDistribution.Sum();

            

            return candyDistribution;
        }
    }
}