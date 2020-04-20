using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class DeepestLeavesSum
    {
        public static int DeepestSum(TreeNode root)
        {
            var dictionary = GetLevels(root);

            foreach (var pair in dictionary)
            {
                Console.WriteLine("Level: " + pair.Key);
                foreach (var i in pair.Value)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(dictionary[dictionary.Count].Sum());
            return dictionary[dictionary.Count].Sum();
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