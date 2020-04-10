using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class GroupPeopleDependingOnGroupSize
    {
        public static IList<IList<int>> GroupPeople(int[] groupSizes)
        {
            IList<IList<int>> result = new List<IList<int>>();
            
            Dictionary<int,int> groupsDic = new Dictionary<int, int>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                groupsDic.Add(i,groupSizes[i]);
            }
            
            var sortedDic = from entry in groupsDic orderby entry.Value ascending select entry;

            IList<int> tempGroup = new List<int>();
            foreach (var pair in sortedDic)
            {
                if (pair.Value > tempGroup.Count && !tempGroup.Contains(pair.Key))
                {
                    tempGroup.Add(pair.Key);
                }
            }
            
            
            Console.WriteLine("Sorted Dictionary:");
            foreach (var pair in sortedDic)
            {
                Console.WriteLine("{0},{1}", pair.Key,pair.Value);
            }

            Console.WriteLine("TempGroup:");
            foreach (var i in tempGroup)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Result:");
            foreach (var list in result)
            {
                foreach (var i in list)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("---");
            }
            
            return result;
        }
    }
}