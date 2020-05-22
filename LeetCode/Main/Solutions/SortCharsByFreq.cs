using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SortCharsByFreq
    {
        public static string FrequencySort(string s)
        {
            var sFreq = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                sFreq[s[i] - 'a']++;
            }
            
            var result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (sFreq[s[i] - 'a'] != 0)
                {
                    
                    result += s[i];
                    sFreq[s[i] - 'a']--;
                }
            }
            Console.WriteLine(result);

            return result;

            // var freqDictionary = new Dictionary<char, int>();
            //
            // for (int i = 0; i < s.Length; i++)
            // {
            //     if (freqDictionary.ContainsKey(s[i]))
            //         freqDictionary[s[i]]++;
            //     else
            //         freqDictionary.Add(s[i], 1);
            // }
            //
            // var orderedDic = freqDictionary.OrderBy(x => x.Value).Reverse();
            //
            // var result = "";
            // foreach (var pair in orderedDic)
            // {
            //     for (int i = 0; i < pair.Value; i++)
            //     {
            //         result += pair.Key;
            //     }
            // }
            //
            //
            // Console.WriteLine(result);
            // return result;
        }
    }
}