using System;

namespace LeetCode.Main.Solutions
{
    public static class MaxDepthOfBinaryTree
    {
        private static int depth = 0;
        public static int MaxDepth(TreeNode root)
        {
            MaxDepthHelper(root, 1);
            return depth;
        }

        private static void MaxDepthHelper(TreeNode node, int level)
        {
            if (node == null)
                return;

            if (level > depth)
                depth = level;

            if (node.left != null)
                MaxDepthHelper(node.left, level+1);
            if (node.right != null)
                MaxDepthHelper(node.right, level+1);
        }
    }
}