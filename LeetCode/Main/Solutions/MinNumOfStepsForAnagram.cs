using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MinNumOfStepsForAnagram
    {
        public static int MinSteps(string s, string t)
        {
            var sortedS = SortString(s);
            var sortedT = SortString(t);

            if (sortedS == sortedT)
                return 0;
            
            Console.WriteLine(sortedS);
            Console.WriteLine(sortedT);

            var dictionaryS = StringToDictionary(s);
            var dictionaryT = StringToDictionary(t);
            
            var count = 0;

            foreach (var pair in dictionaryS)
            {
                if (dictionaryT.ContainsKey(pair.Key) && dictionaryT[pair.Key] != dictionaryS[pair.Key])
                    count += Math.Abs(dictionaryS[pair.Key] - dictionaryT[pair.Key]);
                if (!dictionaryT.ContainsKey(pair.Key))
                    count++;
            }
            
            Console.WriteLine(count);
            return count;
        }

        private static string SortString(string x)
        {
            var sortedListX = x.ToList();
            sortedListX.Sort();
            var sortedX = new string(sortedListX.ToArray());
            return sortedX;
        }

        private static Dictionary<char, int> StringToDictionary(string x)
        {
            var charDictionary = x.GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
            return charDictionary;
        }
    }
}