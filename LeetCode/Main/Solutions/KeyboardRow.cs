using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class KeyboardRow
    {
        public static string[] KeyWords(string[] words)
        {
            var keyBoardLines = new string[3];
            keyBoardLines[0] = "qwertyuiop";
            keyBoardLines[1] = "asdfghjkl";
            keyBoardLines[2] = "zxcvbnm";

            var result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < keyBoardLines.Length; j++)
                {
                    if (!CanCreateWord(keyBoardLines[j], words[i])) continue;
                    result.Add(words[i]);
                    Console.WriteLine(words[i]);
                }
            }
            
            return result.ToArray();
        }

        private static bool CanCreateWord(string keyboardLine, string word)
        {
            word = word.ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                if (!keyboardLine.Contains(word[i]))
                    return false;
            }

            return true;
        }
    }
}