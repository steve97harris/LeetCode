using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class BattleshipsInABoard
    {
        public static int CountBattleships(char[][] board)
        {
            var count = 0;
            
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'x' && (i == 0 || board[i - 1][j] == '.') && (j == 0 || board[i][j - 1] == '.'))
                        count++;
                }
            }

            Console.WriteLine(count);
            return count;
        }
    }
}