using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MorseCode
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            int numberOfWords = 0;

            string letters = "abcdefghijklmnopqrstuvwxyz";
            string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
            
            
            Dictionary<char, string> morseDictionary = new Dictionary<char, string>();
            List<string> result = new List<string>();

            for (int i = 0; i < letters.Length; i++)
            {
                morseDictionary.Add(letters[i], morse[i]);
            }
            
            foreach (string word in words)
            {
                foreach (char character in word)
                {
                    morseDictionary.TryGetValue(character, out string value);
                    result.Add(value);
                }
            }

            

            foreach (KeyValuePair<char,string> xPair in morseDictionary)
            {
                Console.WriteLine(xPair);
            }

            foreach (string x in result)
            {
                Console.WriteLine(x);
            }

            return numberOfWords;
        }
    }
}