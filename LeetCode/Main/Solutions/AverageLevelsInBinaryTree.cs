using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class AverageLevelsInBinaryTree
    {
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            var average = 0;
            var averagesList = new List<double>();

            if (root == null)
                return null;
            
            if (root.left != null && root.right != null)
            {
                average = (root.left.val + root.right.val) / 2;
                averagesList.Add(average);
                AverageOfLevels(root.left);
                AverageOfLevels(root.right);
            }
            else if (root.left != null && root.right == null)
            {
                average = root.left.val;
                averagesList.Add(average);
                AverageOfLevels(root.left);
            }
            else if (root.left == null && root.right != null)
            {
                average = root.right.val;
                averagesList.Add(average);
                AverageOfLevels(root.right);
            }
            else
            {
                average = root.val;
                averagesList.Add(average);
            }

            foreach (var d in averagesList)
            {
                Console.WriteLine(d);
            }

            return averagesList;
        }
    }
}