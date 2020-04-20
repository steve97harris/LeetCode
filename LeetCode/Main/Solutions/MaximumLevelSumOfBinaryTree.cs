using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class MaximumLevelSumOfBinaryTree
    {
        private static Dictionary<int, List<int>> levelDictionary = new Dictionary<int, List<int>>();
        private static int levelCount = 1;
        public static int MaxLevelSum(TreeNode root)
        {
            GetLevels(root);
            
            var sumPerLevel = new List<int>();
            foreach (var pair in levelDictionary)
            {
                Console.WriteLine("Level: " + pair.Key);
                sumPerLevel.Add(pair.Value.Sum());
 
                foreach (var i in pair.Value)
                {
                    Console.WriteLine(i);
                }
            }

            levelDictionary.Clear();
            levelCount = 1;
            
            var result = sumPerLevel.IndexOf(sumPerLevel.Max()) + 1;
            Console.WriteLine("Result: " + result);
            return result;
        }

        private static TreeNode GetLevels(TreeNode root)
        {
            if (root == null) 
                root.val = 0;
            
            var values = new List<int> {root.val};
            
            if (!levelDictionary.ContainsKey(levelCount))
                levelDictionary.Add(levelCount,values);
            else
                levelDictionary[levelCount].Add(root.val);
            
            if (root.left != null && root.right == null)
            {
                levelCount++;
                GetLevels(root.left);
            }
            if (root.right != null && root.left == null)
            {
                levelCount++;
                GetLevels(root.right);
            }

            if (root.right == null || root.left == null) return root;
            levelCount++;
            GetLevels(root.left);
            GetLevels(root.right);

            return root;
        }
    }
}