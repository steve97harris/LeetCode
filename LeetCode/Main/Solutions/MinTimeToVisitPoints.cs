using System;

namespace LeetCode.Main.Solutions
{
    public class MinTimeToVisitPoints
    {
        public static int MinTimeVisitingAllPoints(int[][] points)
        {
            int smallestValue = 0;
            int distanceBetween2Points;
            
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points[i].Length; j++)
                {
                    distanceBetween2Points = points[i + 1][j + 1] - points[i][j];
                }
            }

            return smallestValue;
        }
    }
}