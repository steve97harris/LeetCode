using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class QueensThatCanAttackTheKing
    {
        private static List<IList<int>> queenAttackOptions = new List<IList<int>>();
        private static List<IList<int>> invalidEntries = new List<IList<int>>();

        public static IList<IList<int>> QueensAttackTheKing(int[][] queens, int[] king)
        {
            var diagonals = new Dictionary<IList<int>, int>();        // list, difference in point and king
            
            for (int i = 0; i < queens.Length; i++)
            {
                if (queens[i][0] == king[0] || queens[i][1] == king[1])
                    queenAttackOptions.Add(queens[i].ToList());

                if (IsValidDiagonal(king, queens[i][0], queens[i][1]))
                    diagonals.Add(queens[i], queens[i][0] - king[0]);
            }

            for (int i = 0; i < queenAttackOptions.Count; i++) 
            {
                for (int j = 0; j < queenAttackOptions.Count; j++)
                {
                    CheckForInvalidEntries(i, j, 0, 1);
                    CheckForInvalidEntries(i, j, 1, 0);
                }
            }

            var diagonalValues = diagonals.Values.ToArray();
            var minPos = 10000000;
            var minPosIndex = -1;
            var minNeg = -1000000;
            var minNegIndex = -1;
            for (int i = 0; i < diagonalValues.Length; i++)
            {
                if (diagonalValues[i] > 0)
                {
                    if (diagonalValues[i] < minPos)
                    {
                        minPos = diagonalValues[i];
                        minPosIndex = i;
                    }
                }

                if (diagonalValues[i] < 0)
                {
                    if (diagonalValues[i] > minNeg)
                    {
                        minNeg = diagonalValues[i];
                        minNegIndex = i;
                    }
                }
            }

            var diagonalKeys = diagonals.Keys.ToList();
            if (minPosIndex != -1)
                queenAttackOptions.Add(diagonalKeys[minPosIndex]);
            if (minNegIndex != -1)
                queenAttackOptions.Add(diagonalKeys[minNegIndex]);
            
            for (int i = 0; i < invalidEntries.Count; i++)
            {
                if (queenAttackOptions.Contains(invalidEntries[i]))
                    queenAttackOptions.Remove(invalidEntries[i]);
            }

            Console.WriteLine("------");
            foreach (var l1 in queenAttackOptions)
            {
                Console.WriteLine(l1[0] + ", " + l1[1]);
            }
            
            return queenAttackOptions;
        }
        
        private static bool IsValidDiagonal(int[] knownPt,int x, int y)
        {
            return y== x + knownPt[1] - knownPt[0] || y == -x + knownPt[1] + knownPt[0];
        }

        private static void CheckForInvalidEntries(int i, int j, int x, int y)
        {
            if (queenAttackOptions[i][x] == queenAttackOptions[j][x])
            {
                if (queenAttackOptions[i][y] > queenAttackOptions[j][y])
                {
                    if (!invalidEntries.Contains(queenAttackOptions[i]))
                        invalidEntries.Add(queenAttackOptions[i]);
                }
                        
                if (queenAttackOptions[j][y] > queenAttackOptions[i][y])
                {
                    if (!invalidEntries.Contains(queenAttackOptions[j]))
                        invalidEntries.Add(queenAttackOptions[j]);
                }
            }
        }
    }
}