using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class LongestCommonSubsequence
    {
        public static int LCS(string text1, string text2)
        {
            int[][] dp = new int[text1.Length][];

            for (int i = 0; i < text1.Length; i++)
            {
                for (int j = 0; j < text2.Length; j++)
                {
                    if (text1[i] == text2[j])
                    {
                        dp[i + 1][j + 1] = Math.Max(dp[i][j] + 1, Math.Max(dp[i + 1][j], dp[i][j + 1]));
                    }
                    else
                    {
                        dp[i + 1][j + 1] = Math.Max(dp[i + 1][j], dp[i][j + 1]);
                    }
                }
            }

            foreach (var array in dp)
            {
                Console.WriteLine("---");
                foreach (var i in array)
                {
                    Console.WriteLine(i);
                }
            }

            return dp[text1.Length][text2.Length];
        }
    }
}