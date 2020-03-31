using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class FindAndReplacePattern
    {
        public static IList<string> FindReplacePattern(string[] words, string pattern)
        {
            IList<string> result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (IsIsomorphic(pattern, words[i]))
                {
                    result.Add(words[i]);
                    Console.WriteLine(words[i]);
                }
            }
            
            return result;
        }

        public static bool IsIsomorphic(string strOne, string strTwo)
        {
            int size = 256;
            
            if (strOne.Length != strTwo.Length)
                return false;
            
            bool[] marked = new bool[size];
            for (int i = 0; i < size; i++)
            {
                marked[i] = false;
            }
            
            int[] map = new int[size];
            for (int i = 0; i < size; i++)
            {
                map[i] = -1;
            }

            for (int i = 0; i < strOne.Length; i++)
            {
                if (map[strOne[i]] == -1)
                {
                    if (marked[strTwo[i]] == true)
                        return false;

                    marked[strTwo[i]] = true;

                    map[strOne[i]] = strTwo[i];
                }
                else if (map[strOne[i]] != strTwo[i])
                    return false;
            }

            return true;
        }
    }
}