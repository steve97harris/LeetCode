using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class CountGoodNodesInBinaryTree
    {
        private static int count = 0;
        public static int GoodNodes(TreeNode root)
        {
            var path = new int[1000];
            PathRecursion(root, path, 0);
            

            return count;
        }

        private static void PathRecursion(TreeNode node, int[] path, int pathLength)
        {
            if (node == null)
                return;

            path[pathLength] = node.val;
            pathLength++;
            
            CheckPathIsValid(path, pathLength);
            
            if (node.left != null)
                PathRecursion(node.left, path, pathLength);
            if (node.right != null)
                PathRecursion(node.right, path, pathLength);
        }

        private static void CheckPathIsValid(int[] path, int pathLength)
        {
            var currNodeVal = path[pathLength - 1];
            var isValidPath = true;
            for (int i = 0; i < pathLength; i++)
            {
                if (path[i] > currNodeVal)
                    isValidPath = false;
            }

            if (isValidPath)
                count++;
        }
    }
}