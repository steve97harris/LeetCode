using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class NArayTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            CheekyRecursion(root, 0);

            return NodesFam.Select(pair => pair.Value).Cast<IList<int>>().ToList();
        }

        private Dictionary<int, List<int>> NodesFam = new Dictionary<int, List<int>>();
        private void CheekyRecursion(Node node, int level)
        {
            if (node == null)
                return;
            
            if (NodesFam.ContainsKey(level))
                NodesFam[level].Add(node.val);
            else
                NodesFam.Add(level, new List<int>() {node.val});

            if (node.children == null) 
                return;
            
            var children = node.children;
            for (int i = 0; i < children.Count; i++)
            {
                CheekyRecursion(children[i], level + 1);   
            }
        }
    }
}