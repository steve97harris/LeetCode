using System;
using System.Collections.Generic;

namespace LeetCode.Main.DesignSolutions
{
    public static class TreePreorderTraversal
    {
        private static IList<int> preorderNodeValues = new List<int>();
        public static IList<int> Preorder(Node root)
        {
            var nodeStack = new Stack<Node>();
            nodeStack.Push(root);
            
            while (nodeStack.Count != 0)
            {
                var currentNode = nodeStack.Pop();

                //if (currentNode != null && currentNode.children.Count != 0)
                {
                    foreach (var child in currentNode.children)
                    {
                        // nodeStack.Push(child);
                        Console.WriteLine(child.val);
                    }
                    preorderNodeValues.Add(currentNode.val);
                }
            }
            
            for (int i = 0; i < preorderNodeValues.Count; i++)
            {
                Console.WriteLine(preorderNodeValues[i]);
            }
            
            return preorderNodeValues;
        }
    }
}