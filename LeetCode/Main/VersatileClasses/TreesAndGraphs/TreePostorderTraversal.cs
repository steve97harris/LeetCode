using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LeetCode.Main
{
    public static class TreePostorderTraversal
    {
        private static IList<int> postorderNodeValues = new List<int>();
        public static IList<int> Postorder(Node root)
        {
            if (root == null)
                return null;
            
            PostorderHelper(root);

            foreach (var i in postorderNodeValues)
            {
                Console.WriteLine(i);
            }

            return postorderNodeValues;
        }

        private static void PostorderHelper(Node node)
        {
            if (node.children == null)
                return;

            foreach (var nodeChild in node.children)
            {
                PostorderHelper(nodeChild);
            }
            
            postorderNodeValues.Add(node.val);
        }
    }
}