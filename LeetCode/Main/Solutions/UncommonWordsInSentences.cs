using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class UncommonWordsInSentences
    {
        private static List<string> result = new List<string>();
        public static string[] UncommonWords(string A, string B)
        {
            ScanWords(A,B);
            ScanWords(B,A);
            return result.ToArray();
        }

        private static void ScanWords(string str1, string str2)
        {
            var wordsOfString1 = str1.Split(' ');
            var groupWords = wordsOfString1.GroupBy(s => s)
                .ToDictionary(g => g.Key, g => g.Count());

            var wordsOfString2 = str2.Split(' ');
            foreach (var groupWord in groupWords)
            {
                Console.WriteLine(groupWord.Key + ", " + groupWord.Value);
                if (groupWord.Value == 1 && !wordsOfString2.Contains(groupWord.Key))
                    result.Add(groupWord.Key);
            }
        }
    }
}