using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main
{
    public static class KthLexicographicalStringOfAllHappyStrings
    {
        private static string abc = "abc";
        private static int count = 0;
        public static string GetHappyString(int n, int k)
        {
            var res = Rec(new StringBuilder(), n, k).ToString();
            Console.WriteLine(res);
            return res;
        }
        private static StringBuilder Rec(StringBuilder str, int n, int k)
        {
            if (str.Length == n)
            {
                count++;
                return str;
            }

            for (int i = 0; i < abc.Length; i++)
            {
                if (str.Length != 0 && str[^1] == abc[i]) 
                    continue;
                
                str.Append(abc[i]);
                Rec(str, n, k);

                if (count == k)
                    return str;
                str.Remove(str.Length - 1, 1);
            }
            
            return new StringBuilder();
        }
    }
}