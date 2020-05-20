using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ReverseString
    {
        public static void ReverseLaString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }

            foreach (var c in s)
            {
                Console.WriteLine(c);
            }
        }
    }
}