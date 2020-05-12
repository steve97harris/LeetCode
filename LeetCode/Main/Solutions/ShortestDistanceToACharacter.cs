using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ShortestDistanceToACharacter
    {
        public static int[] ShortestToChar(string s, char c)
        {
            var cIndexes = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                    cIndexes.Add(i);
            }

            var result = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                var temp = new List<int>();
                for (int j = 0; j < cIndexes.Count; j++)
                { 
                    temp.Add(Math.Abs(i - cIndexes[j]));
                }

                result[i] = temp.Min();
                Console.WriteLine(result[i]);
            }

            return result;
        }
    }
}