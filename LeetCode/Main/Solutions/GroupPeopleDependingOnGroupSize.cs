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

            var groupedSortedDic = sortedDic.GroupBy(x => x.Value)
                .ToDictionary(t => t.Key, t => t.Select(r => r.Key).ToList());
            
            var notCurrentlyCorrect = new Dictionary<int,List<int>>();
            foreach (var (key, value) in groupedSortedDic)
            {
                if (key == value.Count)
                {
                    result.Add(value);
                }
                else
                    notCurrentlyCorrect.Add(key,value); 
            }
            
            foreach (var pair in notCurrentlyCorrect)
            {
                var currentList = pair.Value;
                var x = currentList.Select((x, i) => new {Index = i, Value = x})
                    .GroupBy(x => x.Index / pair.Key)
                    .Select(x => x.Select(v => v.Value).ToList())
                    .ToList();
                foreach (var list in x) result.Add(list);
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