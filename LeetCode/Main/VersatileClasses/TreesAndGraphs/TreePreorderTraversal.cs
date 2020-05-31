using System;
using System.Collections.Generic;

namespace LeetCode.Main.DesignSolutions
{
    public static class TreePreorderTraversal
    {
        private static IList<int> preorderNodeValues = new List<int>();
        public static IList<int> Preorder(Node root)
        {
            PreorderHelper(root);

            for (int i = 0; i < preorderNodeValues.Count; i++)
            {
                Console.WriteLine(preorderNodeValues[i]);
            }

            return preorderNodeValues;
        }

        private static void PreorderHelper(Node node)
        {
            if (node == null)
                return;
            
            preorderNodeValues.Add(node.val);

            if (node.children == null) 
                return;
            
            for (int i = 0; i < node.children.Count; i++)
            {
                PreorderHelper(node.children[i]);
            }
        }
    }
}