using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class UniqueNumberOfOccurrences
    {
        public static bool UniqueOccurrences(int[] array)
        {
            List<int> intCount = new List<int>();

            var groups = array.GroupBy(x => x);

            foreach (var @group in groups)
            {
                Console.WriteLine(group.Key + "," + group.Count());
                intCount.Add(group.Count());
            }

            bool isUnique = intCount.Distinct().Count() == intCount.Count();
            Console.WriteLine(isUnique);

            return isUnique;
        }
    }
}