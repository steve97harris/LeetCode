using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class BalanceABinaryTree
    {
        private static List<int> nodeValues = new List<int>();
        public static TreeNode BalanceBST(TreeNode root)
        {
            Nodes(root);
            nodeValues.Sort();
            var newRoot = BuildTree(nodeValues, 0, nodeValues.Count - 1);

            return newRoot;
        }

        private static void Nodes(TreeNode root)
        {
            if (root == null)
                return;
            nodeValues.Add(root.val);

            if (root.left != null)
                Nodes(root.left);
            if (root.right != null)
                Nodes(root.right);
        }

        private static TreeNode BuildTree(List<int> nums, int start, int end)
        {
            if (start > end)
                return null;

            var mid = start + (end - start) / 2;

            var node = new TreeNode(nums[mid])
            {
                left = BuildTree(nums, start, mid - 1), 
                right = BuildTree(nums, mid + 1, end)
            };
            return node;
        }
    }
}