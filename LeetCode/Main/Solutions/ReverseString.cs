using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ReverseString
    {
        public static void ReverseLaString(char[] s)
        {
            List<char> sList = new List<char>();

            foreach (var character in s)
            {
                sList.Add(character);
            }

            sList.Reverse();
            s = sList.ToArray();
            for (int i = 0; i < sList.Count; i++)
            {
                // s[i] = sList[i];
                Console.WriteLine(s[i]);
            }
        }
    }
}