using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class KeyboardRow
    {
        public static string[] KeyWords(string[] words)
        {
            List<string> wordsList = new List<string>();
            
            string topLine = "qwertyuiop";
            string midLine = "asdfghjkl";
            string bottomLine = "zxcvbnm";

            List<string> top = new List<string>();
            List<string> mid = new List<string>();
            List<string> bottom = new List<string>();

            foreach (var word in words)
            {
                wordsList.Add(word);
                foreach (var c in word)
                {
                    if (topLine.Contains(c) && !top.Contains(word))
                    {
                        top.Add(word);
                    }
                    else if (midLine.Contains(c) && !mid.Contains(word))
                    {
                        mid.Add(word);
                    }
                    else if (bottomLine.Contains(c) && !bottom.Contains(word))
                    {
                        bottom.Add(word);
                    }
                }
            }

            for (int i = 0; i < top.Count; i++)
            {
                for (int j = 0; j < top[i].Length; j++)
                {
                    if (!topLine.Contains(top[i][j]))
                    {
                        wordsList.Remove(top[i]);
                    }
                }
            }
            
            for (int i = 0; i < mid.Count; i++)
            {
                Console.WriteLine(mid[i]);
                for (int j = 0; j < mid[i].Length; j++)
                {
                    if (!midLine.Contains(mid[i][j]))
                    {
                        wordsList.Remove(mid[i]);
                    }
                }
            }
            
            for (int i = 0; i < bottom.Count; i++)
            {
                for (int j = 0; j < bottom[i].Length; j++)
                {
                    if (!bottomLine.Contains(bottom[i][j]))
                    {
                        wordsList.Remove(bottom[i]);
                    }
                }
            }

            Console.WriteLine("WordsList:");
            foreach (var word in wordsList)
            {
                Console.WriteLine(word);
            }
            
            return words;
        }
    }
}