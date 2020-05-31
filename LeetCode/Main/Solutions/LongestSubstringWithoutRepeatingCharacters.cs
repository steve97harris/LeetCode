using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s == null)
                return 0;

            var hashtable = new int[256];        // key's - char, value's - position in the string (index)
            for (int m = 0; m < hashtable.Length; m++)
            {
                hashtable[m] = -1;
            }

            var maxLengthOfSubstring = 0;
            var substringStartPosition = 0;
            var i = 0;
            while (i < s.Length)
            {
                if (hashtable[s[i]] != -1)
                {
                    maxLengthOfSubstring = Math.Max(maxLengthOfSubstring, i - substringStartPosition);

                    for (int j = substringStartPosition; j < hashtable[s[i]]; j++)
                    {
                        hashtable[s[j]] = -1;
                    }

                    substringStartPosition = hashtable[s[i]] + 1;
                }

                hashtable[s[i]] = i;
                ++i;
            }

            return Math.Max(maxLengthOfSubstring, i - substringStartPosition);
        }
    }
}