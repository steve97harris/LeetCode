using System.Linq;

namespace LeetCode.Main
{
    public static class FlippingAnImage
    {
        public static int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i].Reverse().ToArray();
                
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] == 1)
                        A[i][j] = 0;
                    else
                        A[i][j] = 1;
                }
            }

            return A;
        }
    }
}