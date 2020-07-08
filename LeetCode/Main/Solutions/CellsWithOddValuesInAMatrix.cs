using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class CellsWithOddValuesInAMatrix
    {
        public static int OddCells(int n, int m, int[][] indices)
        {
            var matrix = new int[n][];
            var indiLength = indices.Length;

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[m];
                for (int l = 0; l < indiLength; l++)
                {
                    matrix[i][indices[l][1]]++;
                }
            }
            
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < indiLength; k++)
                {
                    matrix[indices[k][0]][j]++;
                }
            }

            var res = matrix.Sum(t => t.Count(t1 => t1 % 2 != 0));
            return res;
        }
    }
}