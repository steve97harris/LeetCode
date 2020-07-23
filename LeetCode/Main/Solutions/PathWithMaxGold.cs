using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public class PathWithMaxGold
    {
        private int[][] _grid;
        private int[] nextIndex = new int[] {-1, -1};
        private int bestRouteValue = 0;
        private int totalGold = 0;
        
        public int GetMaximumGold(int[][] grid)
        {
            _grid = grid;
            
            var possibleStartPositions = new List<int[]>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] > 0)
                        possibleStartPositions.Add(new int[] {i, j});
                }
            }

            var res = 0;
            for (int i = 0; i < possibleStartPositions.Count; i++)
            {
                GoldRec(possibleStartPositions[i][0], possibleStartPositions[i][1], new List<int>(), new List<int[]>());
                if (totalGold > res)
                    res = totalGold;
                totalGold = 0;
            }

            Console.WriteLine(res);
            return res;
        }

        private void GoldRec(int i, int j, List<int> route, List<int[]> routeIndexes)
        {
            route.Add(_grid[i][j]);
            totalGold += _grid[i][j];
            routeIndexes.Add(new int[] {i,j});
            
            GetNextIndex(i+1, j, routeIndexes);
            GetNextIndex(i-1, j, routeIndexes);
            GetNextIndex(i, j+1, routeIndexes);
            GetNextIndex(i, j-1, routeIndexes);
        }

        private void GetNextIndex(int indexI, int indexJ, List<int[]> routeIndexes)
        {
            if (indexI < 0 || indexJ < 0)
                return;

            if (indexJ >= _grid[0].Length || indexI >= _grid.Length) 
                return;
            
            var direction = _grid[indexI][indexJ];
            if (direction > bestRouteValue && !routeIndexes.Contains(new int[] {indexI, indexJ}) && direction != 0)
            {
                bestRouteValue = direction;
                nextIndex[0] = indexI;
                nextIndex[1] = indexJ;
            }
        }
    }
}