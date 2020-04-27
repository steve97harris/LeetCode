using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class MaximumSquare
    {
        // 1) Construct a sum matrix S[R][C] for the given M[R][C].
        // a)    Copy first row and first columns as it is from M[][] to S[][]
        // b)    For other entries, use following expressions to construct S[][]
        // If M[i][j] is 1 then
        //     S[i][j] = min(S[i][j-1], S[i-1][j], S[i-1][j-1]) + 1
        // Else /*If M[i][j] is 0*/
        //     S[i][j] = 0
        // 2) Find the maximum entry in S[R][C]
        // 3) Using the value and coordinates of maximum entry in S[i], print 
        //     sub-matrix of M[][]
        public static int MaximalSquare(char[][] matrix)
        {
            var subMatrix = new int[matrix.Length][];

            var maxValue = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                subMatrix[i] = new int[matrix[i].Length];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    subMatrix[i][j] = matrix[i][j] switch
                    {
                        '1' when i >= 1 && j >= 1 => Math.Min(subMatrix[i][j - 1],
                            Math.Min(subMatrix[i - 1][j], subMatrix[i - 1][j - 1])) + 1,
                        '0' => 0,
                        _ => int.Parse(matrix[i][j].ToString())
                    };
                    Console.WriteLine(subMatrix[i][j]);
                    maxValue = Math.Max(maxValue, subMatrix[i][j]);
                }
            }

            var result = (int) Math.Pow(maxValue, 2);
            Console.WriteLine("*" + result);
            return result;
        }
    }
}