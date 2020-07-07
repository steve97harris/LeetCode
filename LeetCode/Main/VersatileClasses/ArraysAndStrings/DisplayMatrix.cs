using System;

namespace LeetCode.Main
{
    public static class DisplayMatrix
    {
        public static void PrintMatrix(this int[][] matrix)
        {
            for(int i=0; i<matrix.Length; i++)
            {
                Console.Write("\n");
                for(int j=0; j<matrix[i].Length; j++)
                    Console.Write("{0}\t",matrix[i][j]);
            }
            Console.Write("\n\n");
        }
    }
}