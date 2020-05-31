using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ValidSudoku
    {
        private static bool validThreeByThrees = true;
        public static bool IsValidSudoku(char[][] board)
        {
            var integerBoard = new int[9][];

            for (int i = 0; i < board.Length; i++)
            {
                var row = new List<int>();
                var col = new List<int>();
                integerBoard[i] = new int[9];
                for (int j = 0; j < board[i].Length; j++)
                {
                    int.TryParse(board[i][j].ToString(), out var result);
                    int.TryParse(board[j][i].ToString(), out var result2);
                    integerBoard[i][j] = result;
                    var rowValue = result;
                    if (rowValue > 0)
                        row.Add(rowValue);
                    var colValue = result2;
                    if (colValue > 0)
                        col.Add(colValue);
                }

                if (!IsValidRowOrCol(row) || !IsValidRowOrCol(col))
                {
                    Console.WriteLine("false");
                    return false;
                }
            }

            var x = new int[] {0, 3, 6};
            var y = new int[] {3, 6, 9};
            var g = new int[] {0, 3, 6, 9};
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < g.Length - 1; j++)
                {
                    CheckThreeByThrees(integerBoard,x[i],y[i],g[j],g[j+1]);
                }
            }
            
            return validThreeByThrees;
        }

        private static bool IsValidRowOrCol(List<int> arr)
        {
            var distinctArr = arr.Distinct().ToList();

            var stringArr = string.Join("", arr);
            var distinctStringArr = string.Join("", distinctArr);
            return stringArr == distinctStringArr;
        }
        
        private static void CheckThreeByThrees(int[][] matrix, int x, int y, int g1, int g2)
        {
            var threes = new List<int>();
            for (int i = x; i < y; i++)
            {
                for (int j = g1; j < g2; j++)
                {
                    if (matrix[i][j] > 0)
                        threes.Add(matrix[i][j]);
                }
            }

            if (!IsValidRowOrCol(threes))
                validThreeByThrees = false;
        }
    }
}