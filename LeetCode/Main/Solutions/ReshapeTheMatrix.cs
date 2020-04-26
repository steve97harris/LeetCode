using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ReshapeTheMatrix
    {
        public static int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            var elementsOfNums = nums.SelectMany(arr => arr).ToList();

            var count = 0;
            var matrix = new int[r][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[c];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    count++;
                    if (count <= elementsOfNums.Count)
                        matrix[i][j] = elementsOfNums[count-1];
                    else
                        return nums;
                }
            }
            
            return matrix;
        }
    }
}