using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class AllElementsInTwoBinarySearchTrees
    {
        private static List<int> allElements = new List<int>();
        public static IList<int> GetAllElements(TreeNode root1, TreeNode root2) 
        {
            GetElements(root1);
            GetElements(root2);
            
            allElements.Sort();

            return allElements;
        }

        private static void GetElements(TreeNode root)
        {
            if (root == null)
                return;

            allElements.Add(root.val);
            
            if (root.left != null)
                GetElements(root.left);
            if (root.right != null)
                GetElements(root.right);
        }
    }
}