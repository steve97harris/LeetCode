using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class OccurrencesAfterBigram
    {
        public static string[] FindOccurrences(string text, string first, string second)
        {
            var occurrences = new List<string>();
            var individualWordsOfText = text.Split(' ');

            for (int i = 2; i < individualWordsOfText.Length; i++)
            {
                if (individualWordsOfText[i - 1] == second && individualWordsOfText[i - 2] == first)
                {
                    occurrences.Add(individualWordsOfText[i]);
                }
            }

            var result = occurrences.ToArray();

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
            return result;
        }
    }
}