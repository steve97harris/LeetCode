using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class IntervalListIntersections
    {
        public static int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            var intersections = new List<int[]>();
            var indexA = 0;
            var indexB = 0;

            while (indexA < A.Length && indexB < B.Length)
            {
                // overlap
                var currentA = A[indexA];
                var currentB = B[indexB];

                var maxStart = Math.Max(currentA[0], currentB[0]);
                var minEnd = Math.Min(currentA[1], currentB[1]);

                var overlap = maxStart <= minEnd;        // true if start is less than or equal end
                if (overlap)
                {
                    var newInterval = new int[] {maxStart, minEnd};
                    
                    intersections.Add(newInterval);

                    if (currentA[1] <= currentB[1])
                        indexA++;
                    else
                        indexB++;
                }
                else         // go to next iteration
                {
                    if (currentA[0] < currentB[0])
                        indexA++;
                    else
                        indexB++;
                }
            }


            return intersections.ToArray();
        }
    }
}