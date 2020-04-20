using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class MaximumLevelSumOfBinaryTree
    {
        public static int MaxLevelSum(TreeNode root)
        {
            var dictionary = GetTreeNodeLevels.GetLevels(root);
            
            var sumPerLevel = new List<int>();
            foreach (var pair in dictionary)
            {
                Console.WriteLine("Level: " + pair.Key);
                sumPerLevel.Add(pair.Value.Sum());
 
                foreach (var i in pair.Value)
                {
                    Console.WriteLine(i);
                }
            }
            
            var result = sumPerLevel.IndexOf(sumPerLevel.Max()) + 1;
            Console.WriteLine("Result: " + result);
            return result;
        }
    }
}