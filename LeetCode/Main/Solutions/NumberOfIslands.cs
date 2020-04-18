using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class NumberOfIslands
    {
        private static int row = 5;
        private static int col = 5;
        public static int NumOfIslands(char[][] grid)
        {
            var islandCount = 0;
            var horizontalLength = grid.GetLength(1);
            var verticalLength = grid.GetLength(0);

            for (int i = 0; i < verticalLength; i++)
            {
                for (int j = 0; j < horizontalLength; j++)
                {
                    if (grid[i][j] == '1') 
                        continue;
                    grid[i][j] = '2';
                    
                    // Queue - First in first out collection of objects
                    Queue<int[]> queue = new Queue<int[]>();
                    
                    queue.Enqueue(new int[2] {i,j});        // Add obj to end of queue

                    while (queue.Count != 0)
                    {
                        int[] islandUnit = queue.Dequeue();        // Removes and returns obj at beginning of queue

                        if (islandUnit[0] < verticalLength - 1 && grid[islandUnit[0] + 1][islandUnit[1]] == '1')
                        {
                            grid[islandUnit[0] + 1][islandUnit[1]] = '2';
                            queue.Enqueue(new int[2] {islandUnit[0] + 1, islandUnit[1]});
                        }
                    }
                }
            }

            return islandCount;
        }
    }
}