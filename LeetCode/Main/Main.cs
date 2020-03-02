using LeetCode.Main.Solutions;

namespace LeetCode.Main
{
    public static class RunMe
    {
        static void Main()
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] {15, 2, -8, 5, 3},
                new int[] {3, -3, 7},
                new int[] {9, 1, -16, 13},
                new int[] {},
                new int[] {5}
            };

            CountTheNegatives.CountNegatives(jaggedArray);
        }
    }
}