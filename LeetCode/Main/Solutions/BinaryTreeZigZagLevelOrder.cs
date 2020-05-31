using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class BinaryTreeZigZagLevelOrder
    {
        private static Dictionary<int,IList<int>> currentLevelValues = new Dictionary<int, IList<int>>();
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            ZigZagHelper(root,1);
            
            var zigzagOrder = new List<IList<int>>();
            foreach (var pair in currentLevelValues)
            {
                if (pair.Key % 2 == 0)
                {
                    var rev = pair.Value.Reverse().ToList();
                    zigzagOrder.Add(rev);
                }
                else
                {
                    zigzagOrder.Add(pair.Value);
                }
            }

            return zigzagOrder;
        }

        private static void ZigZagHelper(TreeNode root, int level)
        {
            if (root == null)
                return;
            
            if (currentLevelValues.ContainsKey(level))
                currentLevelValues[level].Add(root.val);
            else
                currentLevelValues.Add(level,new List<int>(){root.val});
            
            if (root.left != null)
                ZigZagHelper(root.left,level+1);
            if (root.right != null)
                ZigZagHelper(root.right,level+1);
        }
    }
}