using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class QueensThatCanAttackTheKing
    {
        public static IList<IList<int>> QueensAttackTheKing(int[][] queens, int[] king)
        {
            var possibleQueenAttacks = new List<IList<int>>();

            for (int i = 0; i < queens.Length; i++)
            {
                if (queens[i][0] == king[0] || queens[i][1] == king[1])
                    possibleQueenAttacks.Add(queens[i].ToList());
            }

            
            foreach (var list in possibleQueenAttacks)
            {
                Console.WriteLine(list[0] + ", " + list[1]);
            }
            return possibleQueenAttacks;
        }
    }
}