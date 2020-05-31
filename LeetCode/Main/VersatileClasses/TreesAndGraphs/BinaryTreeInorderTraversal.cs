using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class BinaryTreeInorderTraversal
    {
        private static IList<int> inorderList = new List<int>();
        public static IList<int> InorderTraversal(TreeNode root)
        {
            InorderHelper(root);

            foreach (var i in inorderList)
            {
                Console.WriteLine(i);
            }

            return inorderList;
        }

        private static void InorderHelper(TreeNode root)
        {
            if (root == null)
                return;
            
            if (root.left != null)
                InorderHelper(root.left);
            
            inorderList.Add(root.val);
            
            if (root.right != null)
                InorderHelper(root.right);
        }
    }
}