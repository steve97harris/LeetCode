﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class AverageLevelsInBinaryTree
    {
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            var x = GetLevels(root);
            
            IList<double> averages = new List<double>();
            
            foreach (var level in x)
            {
                double average = (float) level.Value.Sum() / level.Value.Count;
                averages.Add(average);
            }

            foreach (var d in averages)
            {
                Console.WriteLine(d);
            }
            
            return averages;
        }

        private static Dictionary<int,List<int>> GetLevels(TreeNode root)
        {
            if (root == null)
                return null;
            
            LinkedList<NodeLevelPair> queue = new LinkedList<NodeLevelPair>();
            var dictionary = new Dictionary<int,List<int>>();
        
            queue.AddLast(new NodeLevelPair(root, 1));
        
            NodeLevelPair pair;
        
            while (queue.Count > 0)
            {
                pair = queue.First.Value;
                queue.RemoveFirst();
                
                //Console.WriteLine("Level of " + pair.node.val + " is " + pair.level);
                if (pair.node.left != null)
                    queue.AddLast(new NodeLevelPair(pair.node.left, pair.level + 1));
                if (pair.node.right != null)
                    queue.AddLast(new NodeLevelPair(pair.node.right, pair.level + 1));
                
                var list = new List<int>() {pair.node.val};
                if (!dictionary.ContainsKey(pair.level))
                    dictionary.Add(pair.level, list);
                else
                    dictionary[pair.level].Add(pair.node.val);
            }
        
            return dictionary;
        }
    }
}