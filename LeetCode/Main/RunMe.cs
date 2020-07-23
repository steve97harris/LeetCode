using System;
using System.Collections.Generic;
using LeetCode.Main.CodingTestYR;
using LeetCode.Main.DesignSolutions;
using LeetCode.Main.Solutions;
using LeetCode.Main.VersatileClasses;
using LeetCode.Main.VersatileClasses.TreesAndGraphs;

namespace LeetCode.Main
{
    namespace LeetCode.Main
    {
        public static class RunMe
        {
            private static void Main()
            {
                var x = new int[][]
                {
                    new int[] {0, 6, 0},
                    new int[] {5, 8, 7},
                    new int[] {0, 9, 0}
                };
                var y = new PathWithMaxGold();
                y.GetMaximumGold(x);
            }

            #region CodeTests

            // int[] A = {10, 5, 7};
            // int[] P = {2, 3};
            // CodingTest.GetQueueTimeWithPrinters(A,P);

            #endregion

            #region VersatileClassesExamples

            // Array to Binary Tree:
            // var nums = new int[] {6, 7, 8, 2, 7, 1, 3, 9, -1, 1, 4, -1, -1, -1, 5};
            // var root = ArrayToBinaryTree.ArrayToBt(nums, new TreeNode(), 0);
            // root.Print();

            #endregion
        }
    }
}