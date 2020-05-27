using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LeetCode.Main
{
    public static class TreePostorderTraversal
    {
        private static Stack<int> stack1 = new Stack<int>();
        private static IList<int> postorderNodeValues = new List<int>();
        public static IList<int> Postorder(Node root)
        {
            PostorderHelper(root);

            foreach (var i in postorderNodeValues)
            {
                Console.WriteLine(i);
            }

            return postorderNodeValues;
        }

        private static void PostorderHelper(Node node)
        {
            if (node == null)
                return;
            
            stack1.Push(node.val);

            while (stack1.Count() != 0)
            {
                var topStack1 = stack1.Pop();
                postorderNodeValues.Add(topStack1);

                if (node.children == null) 
                    return;
                
                for (int i = 0; i < node.children.Count; i++)
                {
                    PostorderHelper(node.children[i]);
                }
            }
        }
    }
}