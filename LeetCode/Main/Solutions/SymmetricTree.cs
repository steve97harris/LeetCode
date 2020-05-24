using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SymmetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            return SymmetryHelper(root.left, root.right);
        }

        private static bool SymmetryHelper(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left == null && right == null;

            return left.val == right.val && SymmetryHelper(left.left, right.right) && SymmetryHelper(left.right, right.left);
        }
    }
}