using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class StringMatchingInAnArray
    {
        public static IList<string> StringMatching(string[] words)
        {
            var wordsInTheWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i].Contains(words[j]) && !wordsInTheWords.Contains(words[j]) && words[i] != words[j])
                        wordsInTheWords.Add(words[j]);
                }
            }
            
            return wordsInTheWords.Count == words.Length ? new List<string>() : wordsInTheWords;
        }
    }
}