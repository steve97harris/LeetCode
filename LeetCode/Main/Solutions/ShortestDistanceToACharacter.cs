using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ShortestDistanceToACharacter
    {
        public static int[] ShortestToChar(string s, char c)
        {
            List<int> indexToC = new List<int>();
            List<int> distanceToChars = new List<int>();
            List<List<int>> listOfLists = new List<List<int>>();
            List<int> result = new List<int>();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    indexToC.Add(i);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < indexToC.Count; j++)
                {
                    int x = indexToC[j] - i;
                    distanceToChars.Add(x);
                }
            }

            for (int i = 0; i < distanceToChars.Count; i = i + 4)
            {
                listOfLists.Add(distanceToChars.Skip(i).Take(4).ToList());
            }

            
            for (int i = 0; i < listOfLists.Count; i++)
            {
                int minAboveZero = listOfLists[i].Min();
                result.Add(minAboveZero);
            }

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            return indexToC.ToArray();
        }
    }
}