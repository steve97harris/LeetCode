using System;

namespace LeetCode.Main
{
    public static class BalanceABinaryTree
    {
        public static TreeNode BalanceBST(TreeNode root)
        {
            Nodes(root,1);

            return root;
        }

        private static void Nodes(TreeNode root, int level)
        {
            if (root == null)
                return;
            Console.WriteLine(root.val + ", Level: " + level);
            
            if (root.left != null)
                Nodes(root.left, level+1);
            if (root.right != null)
                Nodes(root.right, level+1);
        }
    }
}