using System;

namespace LeetCode.Main
{
    public static class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            var sFreq = GetFreq(s);
            var tFreq = GetFreq(t);

            s = ArrayToString(sFreq);
            t = ArrayToString(tFreq);
            return s == t;
        }

        private static string ArrayToString(int[] arr)
        {
            return string.Join("", arr);
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