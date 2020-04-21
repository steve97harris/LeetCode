using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class MaxIncreaseToKeepCitySkyline
    {
        public static int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var leftRightSkyline = grid.Select(array => array.Max()).ToList();
            var topBottomSkyline = grid.Select((t, i) => grid.Select(array => array[i]).ToArray()).Select(x => x.Max()).ToList();

            var result = new List<int>();
            foreach (var t in leftRightSkyline)
            {
                foreach (var t1 in topBottomSkyline)
                {
                    var x = Math.Min(t, t1);
                    result.Add(x);
                }
            }

            var newGrid = result.Select((x, i) => new {Index = i, Value = x})        // Select Index and Value
                .GroupBy(x => x.Index / grid.Length)                                // Group into 4s.
                .Select(x => x.Select(v => v.Value).ToArray()).ToArray();        // Select each value in groups, convert to int[][] 

            var sum = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    var difference = newGrid[i][j] - grid[i][j];
                    sum += difference;
                }
            }
            
            if (newGrid.All(x => x.Sum() == 0))
                return 0;
            
            Console.WriteLine(sum);
            return sum;
        }
    }
}