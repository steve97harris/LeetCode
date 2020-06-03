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
            var cityA = new List<int[]>();        // index [i][0]
            var cityB = new List<int[]>();        // index [i][1]
            
            for (int i = 0; i < costs.Length; i++)
            {
                var currMin = costs[i].Min();
                
                if (costs[i].ToList().IndexOf(currMin) == 0)
                    cityA.Add(costs[i]);
                else
                    cityB.Add(costs[i]);
                
                totalCost += currMin;
            }

            if (cityA.Count == cityB.Count)
                return totalCost;

            if (cityA.Count > cityB.Count)
            {
                var sortedByIndex1 = cityA.OrderBy(x => x[1]).ToList();
                var i = 0;
                while (cityB.Count != cityA.Count)
                {
                    totalCost -= sortedByIndex1[i][0];
                    totalCost += sortedByIndex1[i][1];
                    cityA.Remove(sortedByIndex1[i]);
                    cityB.Add(sortedByIndex1[i]);
                    i++;
                }
            }

            if (cityB.Count > cityA.Count)
            {
                var sortedByIndex0 = cityB.OrderBy(x => x[0]).ToList();
                foreach (var arr in sortedByIndex0)
                {
                    Console.WriteLine("----");
                    foreach (var i1 in arr)
                    {
                        Console.WriteLine(i1);
                    }
                }
                
                var i = 0;
                while (cityB.Count != cityA.Count)
                {
                    //totalCost -= sortedByIndex0[i][1];
                    //totalCost += sortedByIndex0[i][0];
                    cityB.Remove(sortedByIndex0[i]);
                    cityA.Add(sortedByIndex0[i]);
                    i++;
                }
            }

            totalCost = 0;
            
            foreach (var arr in cityA)
            {
                totalCost += arr[0];
                Console.WriteLine(arr);
            }
            Console.WriteLine("----");
            foreach (var arr in cityB)
            {
                totalCost += arr[1];
                Console.WriteLine(arr);
            }

            Console.WriteLine(totalCost);
            return totalCost;
        }
    }
}