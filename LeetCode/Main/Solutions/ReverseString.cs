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

            s = sList.ToArray().Reverse() as char[];

            foreach (var c in s)
            {
                Console.WriteLine(c);
            }
            // for (int i = 0; i < sList.Count; i++)
            // {
            //     s[i] = sList[i];
            //     Console.WriteLine(s[i]);
            // }
        }
    }
}