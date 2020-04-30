using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SortMatrixDiagonally
    {
        public static int[][] DiagonalSort(int[][] mat)
        {
            var elementsInMat = new List<int>();
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    elementsInMat.Add(mat[i][j]);
                }
            }
            elementsInMat.Sort();

            

            return mat;
        }
    }
}