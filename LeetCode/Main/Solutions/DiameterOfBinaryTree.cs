using System;

namespace LeetCode.Main.Solutions
{
    public static class DiameterOfBinaryTree
    {
        public static int maxDiameter;
        
        public static int DiameterOfTree(TreeNode root)
        {
            if (root == null)
                return 0;

            MaxDepth(root);

            Console.WriteLine("Diameter = " + maxDiameter);
            return maxDiameter;
        }

        public static int MaxDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            
            int maxDepthLeft = MaxDepth(node.left);
            int maxDepthRight = MaxDepth(node.right);

            maxDiameter = Math.Max(maxDiameter, maxDepthLeft + maxDepthRight);
            var maxDepth = Math.Max(maxDepthLeft, maxDepthRight) + 1;
            
            Console.WriteLine(maxDepth);
            return maxDepth;
        }
    }
}