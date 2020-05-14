using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class DistributeCandiesToPeople
    {
        public static int[] DistributeDeCandies(int candies, int num_people)
        {
            var peeps = new int[num_people];
            var i = 0;
            var j = 1;
            while (candies != 0)
            {
                if (i > num_people - 1)
                    i = 0;

                if (candies - j < 0)
                {
                    peeps[i] += candies;
                    candies = 0;
                }
                else
                {
                    peeps[i] += j;
                    candies -= j;
                }

                i++;
                j++;
            }

            foreach (var n in peeps)
            {
                Console.WriteLine(n);
            }

            return peeps;
        }
    }
}