using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            var threeByThrees = new List<List<int>>();

            for (int i = 0; i < board.Length; i++)
            {
                var row = new List<int>();
                var col = new List<int>();

                for (int j = 0; j < board[i].Length; j++)
                {
                    int.TryParse(board[i][j].ToString(), out var result);
                    int.TryParse(board[j][i].ToString(), out var result2);
                    if (result != 0 )
                        row.Add(result);
                    if (result2 != 0)
                        col.Add(result2);
                    
                    
                }

                var distinctRow = row.Distinct().ToList();
                if (row != distinctRow)
                {
                    Console.WriteLine("false");
                    return false;
                }
                
                var distinctCol = col.Distinct().ToList();
                if (col != distinctCol)
                {
                    Console.WriteLine("false");
                    return false;
                }

            }

            foreach (var list in threeByThrees)
            {
                Console.WriteLine("----");
                foreach (var i in list)
                {
                    Console.WriteLine(i);
                }
            }

            return true;
        }
    }
}