using System;

namespace LeetCode.Main
{
    public static class TheSpiralMatrixIII
    {
        public static int[][] SpiralMatrixIII(int R, int C, int r0, int c0)
        {
            var matrix = new int[R][];
            
            
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[C];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = -1;
                }
            }

            var s = 0;
            var d = 0;
            var count = 1;
            for (int k=1; k<=(R-1); k++)
            {
                for (int j=0; j<(k<(C-1)?2:3); j++)
                {
                    for (int i=0; i<s; i++)
                    {
                        matrix[r0][c0] = count;
                        count++;

                        switch (d)
                        {
                            case 0: c0 += 1; break;
                            case 1: r0 += 1; break;
                            case 2: c0 -= 1; break;
                            case 3: r0 -= 1; break;
                        }
                    }
                    d = (d+1)%4;
                }
                s += 1;
            }

            matrix.PrintMatrix();
            return matrix;
        }

        // private static void UpdateMatrixValues(int i, int j, int val)
        // {
        //     matrix[i][j] = val;
        //     
        //     // UpdateMatrixValues(i+1, j, val + 1);
        //     // UpdateMatrixValues(i, j+1, val + 1);
        //     // UpdateMatrixValues(i-1, j, val + 1);
        //     // UpdateMatrixValues(i, j-1, val + 1);
        // }
    }
}