using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class AverageLevelsInBinaryTree
    {
        private static IList<List<int>> levels = new List<List<int>>();
        private static List<int> values = new List<int>();
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null)
                return null;
            
            var value = root.val;
            values.Add(value); 
            levels.Add(values);
            
            if (root.left != null && root.right != null)
            {
                AverageOfLevels(root.left);
                AverageOfLevels(root.right);
            }
            
            if (root.left != null && root.right == null)
            {
                AverageOfLevels(root.left);
            }
            
            if (root.left == null && root.right != null)
            {
                AverageOfLevels(root.right);
            }

            var averages = new List<double>();
            if (root.left != null || root.right != null) return averages;
            foreach (var level in levels)
            {
                var average = level.Sum() / level.Count;
                Console.WriteLine(average);
                averages.Add(average);
            }

            return averages;
        }
    }
}