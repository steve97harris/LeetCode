using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class FindAllAnagramsInString
    {
        public static IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            var sFreq = new int[26];
            var pFreq = new int[26];
            foreach(char c in p)
            {
                pFreq[c - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                sFreq[s[i] - 'a']++;
                
                if (i >= p.Length - 1)
                {
                    var isValid = true;
                    for (int j = 0; j < 26; j++)
                    {
                        if (sFreq[j] != pFreq[j])
                        {
                            isValid = false;
                            break;
                        }
                    }
                    
                    if (isValid)
                        result.Add(i - p.Length + 1);

                    sFreq[s[i - p.Length + 1] - 'a']--;
                }
            }

            return result;
        }

        private static int[] StringFrequency(string str)
        {
            var strFreq = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                strFreq[str[i] - 'a']++;
            }
            return strFreq;
        }
    }
}