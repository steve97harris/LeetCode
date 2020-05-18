using System;
using System.Linq;

namespace LeetCode.Main
{
    public static class PermutationInString
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            var s1Freq = GetFreq(s1);

            var s2Freq = new int[26];

            for (int i = 0; i < s2.Length; i++)
            {
                s2Freq[s2[i] - 'a']++;
                if (i >= s1.Length - 1)
                {
                    if (CheckFreqs(s1Freq, s2Freq))
                    {
                        Console.WriteLine("true");
                        return true;
                    }

                    s2Freq[s2[i - (s1.Length - 1)] - 'a']--;
                }
            }

            Console.WriteLine("false");
            return false;
        }

        private static bool CheckFreqs(int[] one, int[] two)
        {
            for (int i = 0; i < 26; i++)
            {
                if (one[i] != two[i])
                    return false;
            }

            return true;
        }

        private static int[] GetFreq(string str)
        {
            var freq = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                freq[str[i] - 'a']++;
            }
        
            return freq;
        }
    }
}