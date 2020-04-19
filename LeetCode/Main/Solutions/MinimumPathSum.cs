using System;

namespace LeetCode.Main.Solutions
{
    public static class MinimumPathSum
    {
        // static int n = grid.length (n=3, 3x3 grid)
        public static int MinPathSum(int[][] grid)
        {
            var n = grid.Length;
            if (n == 0)
                return 0;

            var m = grid[0].Length;
            var dp = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[i, j] = grid[i][j];
                    }
                    else if (i == 0)
                    {
                        dp[i, j] = dp[i, j - 1] + grid[i][j];
                    }
                    else if (j == 0)
                    {
                        dp[i, j] = dp[i - 1, j] + grid[i][j];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
                    }
                }
            }

            return dp[n - 1, m - 1];
        }
    }
}