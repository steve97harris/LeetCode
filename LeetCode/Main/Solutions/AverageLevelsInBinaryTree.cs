using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class AverageLevelsInBinaryTree
    {
        private static Dictionary<int, List<int>> nodeLevels = new Dictionary<int, List<int>>();
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            AverageOfLevelsHelper(root,1);
            return nodeLevels.Select(pair => pair.Value.Average()).ToList();
        }

        private static void AverageOfLevelsHelper(TreeNode node, int level)
        {
            if (node == null)
                return;

            if (nodeLevels.ContainsKey(level))
                nodeLevels[level].Add(node.val);
            else
                nodeLevels.Add(level, new List<int>() {node.val});

            if (node.left != null)
            {
                AverageOfLevelsHelper(node.left, level + 1);
            }

            if (node.right != null)
            {
                AverageOfLevelsHelper(node.right,level + 1);
            }
        }
    }
}