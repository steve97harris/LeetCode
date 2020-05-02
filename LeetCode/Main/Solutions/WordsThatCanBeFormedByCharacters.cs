using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class WordsThatCanBeFormedByCharacters
    {
        public static int CountCharacters(string[] words, string chars)
        {
            var count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (CanCreateStr2(chars, words[i]))
                    count += words[i].Length;
            }
            
            Console.WriteLine(count);
            return count;
        }

        private static bool CanCreateStr2(string chars, string str2)
        {
            var count = new int[256];

            for (int i = 0; i < chars.Length; i++)
            {
                count[chars[i]]++;
            }

            for (int i = 0; i < str2.Length; i++)
            {
                if (count[str2[i]] == 0)
                    return false;
                count[str2[i]]--;
            }

            return true;
        }
    }
}