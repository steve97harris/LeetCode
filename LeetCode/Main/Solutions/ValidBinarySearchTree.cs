using System;

namespace LeetCode.Main
{
    public static class ValidBinarySearchTree
    {
        private static int rootVal;
        public static bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;
            
            rootVal = root.val;
            
            Console.WriteLine(ValidBSTHelper(root, 1, false, false));
            return ValidBSTHelper(root, 1, false, false);
        }
        private static bool ValidBSTHelper(TreeNode node, int level, bool isLeftTree, bool isRightTree)
        {
            // if (node == null)
            //     return true;

            if (node.val <= rootVal && isRightTree)
                return false;
            if (node.val >= rootVal && isLeftTree)
                return false;
            
            if (node.left != null)
            {
                if (node.left.val >= node.val)
                    return false; 
                
                if (level == 1)
                    ValidBSTHelper(node.left, level + 1, true, false);

                ValidBSTHelper(node.left, level + 1, isLeftTree, isRightTree);
            }

            if (node.right != null)
            {
                if (node.right.val <= node.val)
                    return false;
                
                if (level == 1)
                    ValidBSTHelper(node.right, level + 1, false, true);
                
                ValidBSTHelper(node.right, level + 1, isLeftTree, isRightTree);
            }

            return true;
        }
    }
}