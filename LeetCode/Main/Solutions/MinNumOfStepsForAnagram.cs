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
            var sCount = new int[26];
            var tCount = new int[26];
            
            for (int i = 0; i < s.Length; i++)
            {
                sCount[s[i] - 'a']++;
                tCount[t[i] - 'a']++;
            }
            
            var count = 0;
            for (int i = 0; i < 26; i++)
            {
                if (sCount[i] > tCount[i])
                    count += sCount[i] - tCount[i];
            }
            
            Console.WriteLine(count);
            
            return count;
            
            
            // var sortedS = SortString(s);
            // var sortedT = SortString(t);
            //
            // if (sortedS == sortedT)
            //     return 0;
            //
            // Console.WriteLine(sortedS);
            // Console.WriteLine(sortedT);
            //
            // var dictionaryS = StringToDictionary(s);
            // var dictionaryT = StringToDictionary(t);
            //
            // var count = 0;
            //
            // foreach (var pair in dictionaryS)
            // {
            //     if (dictionaryT.ContainsKey(pair.Key) && dictionaryS[pair.Key] > dictionaryT[pair.Key])
            //         count += Math.Abs(dictionaryS[pair.Key] - dictionaryT[pair.Key]);
            // }
            //
            // Console.WriteLine(count);
            // return count;
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