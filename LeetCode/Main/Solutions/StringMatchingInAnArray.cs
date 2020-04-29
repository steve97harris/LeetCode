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
            var list = new List<string[]>();
            foreach (var str in words)
            {
                wordsInTheWords.Add(str);
                var x = words.Select(word => word)
                    .Where(word => word.Contains(str) && word != str).ToArray();
                list.Add(x);
            }
            foreach (var s in list.SelectMany(arr => arr))
            {
                if (wordsInTheWords.Contains(s))
                    wordsInTheWords.Remove(s);
            }

            foreach (var w in wordsInTheWords)
            {
                Console.WriteLine(w);
            }
            
            return wordsInTheWords.Count == words.Length ? new List<string>() : wordsInTheWords;
        }
    }
}