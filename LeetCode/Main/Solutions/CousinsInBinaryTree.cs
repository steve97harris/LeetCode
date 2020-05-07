using System;

namespace LeetCode.Main.Solutions
{
    public static class CousinsInBinaryTree
    {
        private static int depthLeft = 0;
        private static int depthRight = 0;
        private static int cousinA = 0;
        private static int cousinB = 0;
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            // cousins - same depth, but different parent.
            var nodeLevel = GetNodeLevel(root, root.val);

            if (root.left != null)
            {
                depthLeft++;
                IsCousins(root.left, x, y);
            }

            if (root.right != null)
            {
                depthRight++;
                IsCousins(root.right, x, y);
            }

            Console.WriteLine(cousinA);
            Console.WriteLine(cousinB);
            return cousinA > 0 && cousinB > 0;
        }

        private static int GetNodeLevel(TreeNode node, int val)
        {
            return GetNodeLevelHelper(node, val, 1);
        }

        private static int GetNodeLevelHelper(TreeNode node, int val, int level)
        {
            if (node == null)
                return 0;
            if (node.val == val)
                return level;
            var downLevel = GetNodeLevelHelper(node.left, val, level + 1);
            if (downLevel != 0)
                return downLevel;
            downLevel = GetNodeLevelHelper(node.right, val, level + 1);
            return downLevel;
        }
    }
}