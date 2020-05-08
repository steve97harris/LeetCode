using System;

namespace LeetCode.Main.Solutions
{
    public static class CousinsInBinaryTree
    {
        private static TreeNode parentNode;
        private static int nodeLevel;
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            // cousins - same depth, but different parent.

            GetNodeDepth(root, x,0);
            var levelOfX = nodeLevel;
            Console.WriteLine("Level X: " + levelOfX);
            var parentOfXVal = parentNode;
            
            GetNodeDepth(root, y, 0);
            var levelOfY = nodeLevel;
            Console.WriteLine("Level Y: " + levelOfY);
            var parentOfYVal = parentNode;

            if (levelOfX == levelOfY && parentOfXVal != parentOfYVal)
            {
                Console.WriteLine("T");
                return true;
            }

            Console.WriteLine("F");
            return false;
        }

        private static void GetNodeDepth(TreeNode root, int valOfNode, int level)
        {
            if (root.left != null)
            {
                if (root.left.val == valOfNode)
                    parentNode = root;
                GetNodeDepth(root.left, valOfNode, level + 1);
            }

            if (root.right != null)
            {
                if (root.right.val == valOfNode)
                    parentNode = root;
                GetNodeDepth(root.right, valOfNode, level + 1);
            }

            if (root.val != valOfNode) return;
            nodeLevel = level;
        }
    }
}