using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    
    public class PathWithMaxGold
    {
        private int[][] _grid;
        public int GetMaximumGold(int[][] grid)
        {
            _grid = grid;
            
            var possibleStartPositions = new List<int[]>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (_grid[i][j] > 0)
                        possibleStartPositions.Add(new int[] {i, j});
                }
            }

            var res = 0;
            var bestPath = new List<int>();
            for (int i = 0; i < possibleStartPositions.Count; i++)
            {
                var startPosI = possibleStartPositions[i][0];
                var startPosJ = possibleStartPositions[i][1];
                var startString = startPosI.ToString() + startPosJ.ToString();
                var startValue = _grid[startPosI][startPosJ];
                var pathPositions = new List<string>() { startString };
                var pathValues = new List<int>() { startValue };
                GoldRec(startPosI, startPosJ, pathValues, pathPositions);

                var totalGold = pathValues.Sum();
                if (totalGold > res)
                {
                    res = totalGold;
                    bestPath = pathValues;
                }
            }
            
            foreach (var i in bestPath)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------");
            
            Console.WriteLine(res);
            
            return res;
        }

        private void GoldRec(int i, int j, List<int> route, List<string> routeIndexes)
        {
            var possibleMoves = new List<int[]>
            {
                new int[] {i + 1, j}, 
                new int[] {i - 1, j}, 
                new int[] {i, j + 1}, 
                new int[] {i, j - 1}
            };

            var bestMove = 0;
            var bestI = 0;
            var bestJ = 0;
            for (int k = 0; k < possibleMoves.Count; k++)
            {
                var newIndexI = possibleMoves[k][0];
                var newIndexJ = possibleMoves[k][1];
                
                if (newIndexI < 0 || newIndexJ < 0)
                    continue;

                if (newIndexJ >= _grid[0].Length || newIndexI >= _grid.Length) 
                    continue;
                
                var currentPositionValue = _grid[newIndexI][newIndexJ];
                var stringPos = newIndexI.ToString() + newIndexJ.ToString();
                
                // need to fix, if currentPositionValue == bestMove 
                // if two options are equal 3, which route do we take ?
                
                if (currentPositionValue > bestMove && !routeIndexes.Contains(stringPos))
                {
                    bestMove = currentPositionValue;
                    bestI = newIndexI;
                    bestJ = newIndexJ;
                }
            }

            var bestPosString = bestI.ToString() + bestJ.ToString();
            if (routeIndexes.Contains(bestPosString) || bestMove <= 0) 
                return;
            
            route.Add(bestMove);
            routeIndexes.Add(bestPosString);
                
            GoldRec(bestI, bestJ, route, routeIndexes);
        }
    }
}