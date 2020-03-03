using System;
using LeetCode.Main.Solutions;

namespace LeetCode.Main
{
    public static class RunMe
    {
        static void Main()
        {
            int[][] points = new int[][]
            {
                new int[] {1,1},
                new int[] {3,4},
                new int[] {-1,0}, 
            };

            MinTimeToVisitPoints.MinTimeVisitingAllPoints(points);
        }
    }
}