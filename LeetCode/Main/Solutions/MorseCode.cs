using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MorseCode
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            var morseWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                var morseWord = TranslateToMorse(words[i]);
                if (!morseWords.Contains(morseWord))
                    morseWords.Add(morseWord);
            }
            
            return morseWords.Count;
        }

        private static string TranslateToMorse(string word)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyz";
            var morse = new string[] {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
            
            var morseDictionary = new Dictionary<char, string>();
            for (int i = 0; i < letters.Length; i++)
            {
                morseDictionary.Add(letters[i],morse[i]);
            }

            return word.Aggregate("", (current, t) => current + morseDictionary[t]);
        }
    }
}