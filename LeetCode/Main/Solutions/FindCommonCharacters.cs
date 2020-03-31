using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class FindCommonCharacters
    {
        public static IList<string> CommonChars(string[] words)
        {
            IList<string> result = new List<string>();

            var charCount = new int[words.Length, 26];     // 2 dimensional array of characters and character count.
            
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];

                foreach (var character in currentWord)
                {
                    charCount[i, character - 'a']++;        // count each char in each word and do it for all words in input strings
                }
            }

            for (int i = 0; i < 26; i++)
            {
                int min = charCount[0, i];

                for (int j = 0; j < words.Length; j++)
                {
                    var current = charCount[j, i];
                    if (current < min)
                        min = current;
                    else
                        min = min;
                }

                for (int j = 0; j < min; j++)
                {
                    var c = (char) ('a' + i);
                    result.Add(c.ToString());
                }
            }
            
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            return result;
        }
    }
}