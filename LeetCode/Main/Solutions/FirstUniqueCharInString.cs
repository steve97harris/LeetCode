using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class FirstUniqueCharInString
    {
        public static int FirstUniqChar(string s)
        {
            var freq = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i] - 'a'] == 1)
                    return i;
            }

            return -1;
        }
    }
}