using System;

namespace LeetCode.Main.Solutions
{
    public class MinTimeToVisitPoints
    {
        public static int MinTimeVisitingAllPoints(int[][] points)
        {
            int minimum = 0;
            int[] current = points[0];

            for (int i = 0; i < points.Length; i++)
            {
                int[] point = points[i];
                minimum += FindDistance(current, point);
                current = point;
            }

            return minimum;
        }

        private static int FindDistance(int[] current, int[] point)
        {
            int minimum = 0;
            int x1 = current[0];
            int x2 = point[0];
            int y1 = current[1];
            int y2 = point[1];
            
            // Compute diagonal
            int horizontal = Math.Abs(x2 - x1);        // Difference in horizontal values
            int vertical = Math.Abs(y2 - y1);        // Difference in vertical values
            int distance = Math.Min(horizontal, vertical);        // Find min value of horizontal and vertical 
            
            if (horizontal > vertical)
            {
                minimum = minimum + (horizontal - distance);
            }
            else
            {
                minimum = minimum + (vertical - distance);
            }

            return (minimum = minimum + distance);
        }
    }
}