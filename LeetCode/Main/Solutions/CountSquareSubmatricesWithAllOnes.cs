using System;

namespace LeetCode.Main
{
    public static class CountSquareSubmatricesWithAllOnes
    {
        public static int CountSquares(int[][] matrix)
        {
            var sum = 0;
            for (int i = 1; i < matrix.Length + 1; i++)
            {
                sum += GetSubsquaresSizeK(matrix, i);
            }
            
            Console.WriteLine(sum);
            return sum;
        }

        private static int GetSubsquaresSizeK(int[][] matrix, int k)
        {
            if (k > matrix.Length)
                return 0;

            var squareCount = 0;
            for (int i = 0; i < matrix.Length - k + 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - k + 1; j++)
                {
                    var isValidSquare = true;
                    for (int l = i; l < k+i; l++)
                    {
                        for (int m = j; m < k+j; m++)
                        {
                            if (matrix[l][m] != 1)
                                isValidSquare = false;
                        }
                    }

                    if (isValidSquare)
                        squareCount++;
                }
            }

            return squareCount;
        }
    }
}