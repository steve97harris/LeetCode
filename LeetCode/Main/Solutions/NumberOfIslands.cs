using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class NumberOfIslands
    {
        private static int m = 0;
        private static int n = 0;
        public static int NumOfIslands(char[][] grid)
        {
            n = grid.Length;
            if (n == 0) return 0;
            m = grid[0].Length;

            var isVisited = new bool[n, m];

            var count = 0;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (!isVisited[i, j] && grid[i][j] == '1') {
                        DFS(grid, i, j, isVisited);
                        count++;
                    }
                }
            }

            return count;
        }
        
        // Depth First Search:
        private static void DFS(char[][] grid, int x, int y, bool[,] isVisited) {
            if (x >= n || x < 0 || y >= m || y < 0) {
                return;
            }

            if (isVisited[x, y]) return;
            if (grid[x][y] == '0') return;

            isVisited[x, y] = true;

            var directions = new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };

            foreach (var direction in directions) {
                var nextX = x + direction.Item1;
                var nextY = y + direction.Item2;

                DFS(grid, nextX, nextY, isVisited);
            }
        }
    }
}