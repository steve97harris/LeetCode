using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class TwoCityScheduling
    {
        public static int TwoCitySchedCost(int[][] costs)
        {
            var totalCost = 0;

            if (costs.Length == 0)
                return 0;

            var orderByDescending = costs.OrderByDescending(x => x[0] - x[1]).ToArray();

            for (int i = 0; i < orderByDescending.Length; i++)
            {
                if (i < orderByDescending.Length/2)
                    totalCost += orderByDescending[i][1];
                else
                {
                    totalCost += orderByDescending[i][0];
                }            
            }

            Console.WriteLine(totalCost);
            return totalCost;
        }
    }
}