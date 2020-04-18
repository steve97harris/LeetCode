using System;

namespace LeetCode.Main.Solutions
{
    public static class MinimumPathSum
    {
        // static int n = grid.length (n=3, 3x3 grid)
        public static int MinPathSum(int[][] grid)
        {
            for (int r = grid.Length - 2; r >= 0; --r)
            {
                for (int c = 0; c < grid.Length; ++c)
                {
                    int best = grid[r + 1][c];
                    if (c > 0)
                        best = Math.Min(best, grid[r + 1][c - 1]);
                    if (c + 1 < grid.Length)
                        best = Math.Min(best, grid[r + 1][c + 1]);
                    grid[r][c] = grid[r][c] + best;
                }
            }

            int result = int.MaxValue;
            for (int i = 0; i < grid.Length; ++i)
            {
                result = Math.Min(result, grid[0][i]);
            }

            Console.WriteLine(result);
            return result;
        }
    }
}