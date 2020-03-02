using System;

namespace LeetCode.Main.Solutions
{
    public class StringSplit
    {
        public static int BalancedStringSplit(string s)
        {
            int numberOfRLs = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[i + 1] && s[i] == 'R')
                {
                    Console.WriteLine("RL");
                    // ++numberOfRLs;
                }
            }
            // Console.WriteLine(numberOfRLs);
            return numberOfRLs;
        }
    }
}