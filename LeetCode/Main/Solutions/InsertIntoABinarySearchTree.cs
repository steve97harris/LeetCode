using System;

namespace LeetCode.Main
{
    public static class InsertIntoABinarySearchTree
    {
        public static TreeNode InsertIntoBST(TreeNode root, int value)
        {
            var newNode = new TreeNode(value);
            
            if (root.left == null && root.val > value)
            {
                root.left = newNode;
                Console.WriteLine("Root val: " + root.val);
                Console.WriteLine("Left: " + newNode.val);
            }

            if (root.right == null && root.val < value)
            {
                root.right = newNode;
                Console.WriteLine("Root val: " + root.val);
                Console.WriteLine("Right: " + newNode.val);
            }

            if (root.left != null && root.val > value)
                InsertIntoBST(root.left, value);

            if (root.right != null && root.val < value)
                InsertIntoBST(root.right, value);

            return root;
        }
    }
}