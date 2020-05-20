using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class KthSmallestElementInABST
    {
        private static List<int> nodes = new List<int>();
        public static int KthSmallest(TreeNode root, int k)
        {
            GetNodes(root);
            nodes.Sort();
            
            Console.WriteLine(nodes[k - 1]);
            return nodes[k-1];
        }

        private static void GetNodes(TreeNode node)
        {
            if (node == null)
                return;
            
            nodes.Add(node.val);
            
            if (node.right != null)
                GetNodes(node.right);
            if (node.left != null)
                GetNodes(node.left);
        }
    }
}