using System;

namespace LeetCode.Main
{
    public static class BinaryTreeMaximumPathSum
    {
        public static int MaxPathSum(TreeNode root)
        {
            Res result = new Res();
            result.val = int.MinValue;
            MaxPathSumHelper(root, result);

            return result.val;
        }

        private static int MaxPathSumHelper(TreeNode node, Res res)
        {
            if (node == null)
                return 0;
            if (node.left == null && node.right == null)
                return node.val;

            var leftSubtree = MaxPathSumHelper(node.left, res);
            var rightSubtree = MaxPathSumHelper(node.right, res);

            if (node.left != null && node.right != null)
            {
                res.val = Math.Max(res.val, leftSubtree + rightSubtree + node.val);

                return Math.Max(leftSubtree, rightSubtree) + node.val;
            }

            return (node.left == null) ? rightSubtree + node.val : leftSubtree + node.val;
        }
    }

    public class Res
    {
        public int val;
    }
}