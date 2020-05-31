using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class SetMatrixZeroes
    {
        public static void SetZeroes(int[][] matrix)
        {
            var zeroIndexes = new List<int[]>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        var zeroPoint = new int[] {i, j};
                        zeroIndexes.Add(zeroPoint);
                    }
                }
            }

            for (int i = 0; i < zeroIndexes.Count; i++)
            {
                matrix = SetRowAndColumnsToZero(matrix, zeroIndexes[i][0], zeroIndexes[i][1]);
            }
            DisplayMatrix(matrix);
        }

        private static int[][] SetRowAndColumnsToZero(int[][] matrix, int i, int j)
        {
            var k = 0;
            while (k < matrix.Length)
            {
                matrix[k][j] = 0;
                k++;
            }

            var l = 0;
            while (l < matrix[0].Length)
            {
                matrix[i][l] = 0;
                l++;
            }

            return matrix;
        }

        private static void DisplayMatrix(int[][] matrix)
        {
            var rowCount = matrix.Length;
            var colCount = matrix[0].Length;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i][j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}