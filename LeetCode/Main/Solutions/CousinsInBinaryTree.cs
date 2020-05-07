using System;

namespace LeetCode.Main.Solutions
{
    public static class CousinsInBinaryTree
    {
        private static TreeNode parentNode;
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            // cousins - same depth, but different parent.

            var levelOfX = GetNodeDepth(root, x,0);
            Console.WriteLine(levelOfX);
            var parentOfXVal = parentNode;
            
            var levelOfY = GetNodeDepth(root, y, 0);
            Console.WriteLine(levelOfY);
            var parentOfYVal = parentNode;

            if (levelOfX == levelOfY && parentOfXVal != parentOfYVal)
            {
                Console.WriteLine("T");
                return true;
            }

            Console.WriteLine("F");
            return false;
        }

        private static int GetNodeDepth(TreeNode root, int valOfNode, int level)
        {
            if (root.val == valOfNode)
            {
                Console.WriteLine(root.val);
                // Console.WriteLine("level: " + level);
                return level;
            }
            
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
            
            return -1;
        }
    }
}