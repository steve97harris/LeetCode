using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class AverageLevelsInBinaryTree
    {
        private static Dictionary<int,List<int>> levelDic = new Dictionary<int, List<int>>();
        private static int levelCount = 0;
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            GenerateLevelsDictionary(root);
            
            IList<double> averages = new List<double>();
            if (root.left == null && root.right == null)
            {
                foreach (var level in levelDic)
                {
                    double average = (float) level.Value.Sum() / level.Value.Count;
                    if (!averages.Contains(average))
                        averages.Add(average);
                }

                foreach (var d in averages)
                {
                    Console.WriteLine(d);
                }
            }
            return averages;
        }

        private static TreeNode GenerateLevelsDictionary(TreeNode root)
        {
            if (root == null)
                return null;

            var value = root.val;
            var values = new List<int> {value};
            if (!levelDic.ContainsKey(levelCount))
            {
                levelDic.Add(levelCount, values);
            }
            else
            {
                levelDic[levelCount].Add(value);
            }
            
            if (root.left != null && root.right != null)
            {
                levelCount++;
                AverageOfLevels(root.left);
                AverageOfLevels(root.right);
            }
            
            if (root.left != null && root.right == null)
            {
                levelCount++;
                AverageOfLevels(root.left);
            }
            
            if (root.left == null && root.right != null)
            {
                levelCount++;
                AverageOfLevels(root.right);
            }

            return root;
        }
    }
}