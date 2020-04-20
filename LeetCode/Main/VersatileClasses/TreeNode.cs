using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public class TreeNode
    {
        public int val;
        public TreeNode left; 
        public TreeNode right;

        public TreeNode(int x) 
        { 
            val = x; 
        }
    }

    public class NodeLevelPair
    {
        public TreeNode node;
        public int level;

        public NodeLevelPair(TreeNode node, int level)
        {
            this.node = node;
            this.level = level;
        }
    }

    public static class GetNodesAndLevels
    {
        public static Dictionary<int,List<int>> GetLevels(TreeNode root)
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