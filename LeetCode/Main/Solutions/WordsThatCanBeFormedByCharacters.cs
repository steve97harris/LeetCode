using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class WordsThatCanBeFormedByCharacters
    {
        public static int CountCharacters(string[] words, string chars)
        {
            List<string> goodWords = new List<string>();
            List<string> badWords = new List<string>();
            foreach (var word in words)
            {
                goodWords.Add(word);
                foreach (var character in word)
                {
                    if (!chars.Contains(character) && !badWords.Contains(word))
                    {
                        badWords.Add(word);
                    }
                }
            }

            foreach (var badWord in badWords)
            {
                if (goodWords.Contains(badWord))
                {
                    goodWords.Remove(badWord);
                }
            }

            int charCount = 0;
            foreach (var goodWord in goodWords)
            {
                Console.WriteLine(goodWord);
                foreach (var character in goodWord)
                {
                    ++charCount;
                }
            }

            Console.WriteLine(charCount);
            return charCount;
        }
    }
}