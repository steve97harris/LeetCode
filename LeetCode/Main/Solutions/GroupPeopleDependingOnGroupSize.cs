using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class GroupPeopleDependingOnGroupSize
    {
        public static IList<IList<int>> GroupPeople(int[] groupSizes)
        {
            IList<IList<int>> groupPeople = new List<IList<int>>();
            Dictionary<int,int> groupsDic = new Dictionary<int, int>();

            for (int i = 0; i < groupSizes.Length; i++)
            {
                groupsDic.Add(i,groupSizes[i]);
            }

            foreach (var pair in groupsDic)
            {
                Console.WriteLine("{0},{1}", pair.Key,pair.Value);
            }

            return groupPeople;
        }
    }
}