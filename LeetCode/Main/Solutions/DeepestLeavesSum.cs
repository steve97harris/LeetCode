using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class DeepestLeavesSum
    {
        public static int DeepestSum(TreeNode root)
        {
            var deepestValues = new List<int>();
            // int maxDepthLeft = 0;
            // int maxDepthRight = 0;
            
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                deepestValues.Add(root.val);
            else if (root.left != null && root.right == null)
            {
                 DeepestSum(root.left);
            }
            else if (root.left == null && root.right != null)
            {
                DeepestSum(root.right);
            }
            else
            {
                DeepestSum(root.left);
                DeepestSum(root.right);
            }
            
            
            foreach (var i in deepestValues)
            {
                Console.WriteLine(i);
            }
            return deepestValues.Sum();
        }
    }
}