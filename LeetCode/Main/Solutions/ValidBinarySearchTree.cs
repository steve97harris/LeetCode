using System;

namespace LeetCode.Main
{
    public static class ValidBinarySearchTree
    {
        private static TreeNode prev;
        public static bool IsValidBST(TreeNode root)
        {
            return ValidBSTHelper(root);
        }
        
        private static bool ValidBSTHelper(TreeNode node)
        {
            if (node == null) 
                return true;
            
            if (!ValidBSTHelper(node.left))
                return false;

            if (prev != null && node.val <= prev.val)
                return false;

            prev = node;

            return ValidBSTHelper(node.right);

        }
    }
}