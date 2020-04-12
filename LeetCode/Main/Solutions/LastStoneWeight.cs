using System;
using System.Collections.Generic;
using System.Linq;
using static System.Array;

namespace LeetCode.Main
{
    public static class LastStoneWeight
    {
        public static int LastWeight(int[] stones)
        {
            var stonesList = new List<int>();
            for (int i = 0; i < stones.Length; i++)
            {
                stonesList.Add(stones[i]);
            }
            
            while (stonesList.Count >= 2)
            {
                stonesList.Sort();
                stonesList.Reverse();
                if (stonesList[0] == stonesList[1] && stonesList.Count > 2)
                {
                    Console.WriteLine("case 1");
                    stonesList.RemoveRange(0,2);
                }
                else if (stonesList[0] != stonesList[1] && stonesList.Count > 2)
                {
                    Console.WriteLine("case 2");
                    var diffInHighestValues = stonesList[0] - stonesList[1];
                    stonesList.RemoveRange(0,2);
                    stonesList.Add(diffInHighestValues);
                }
                else if (stonesList[0] == stonesList[1] && stonesList.Count == 2)
                {
                    Console.WriteLine("case 3");
                    stonesList.Remove(stonesList[1]);
                    stonesList[0] = 0;
                }
                else if (stonesList[0] != stonesList[1] && stonesList.Count == 2)
                {
                    Console.WriteLine("case 4");
                    var diffInHighestValues = stonesList[0] - stonesList[1];
                    stonesList.Remove(stonesList[1]);
                    stonesList[0] = diffInHighestValues;
                    Console.WriteLine(stonesList[0]);
                }
            }

            Console.WriteLine("Final Val: " + stonesList[0]);
            return stonesList[0];
        }
    }
}