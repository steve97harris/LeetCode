using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class SumOfNodesWithEvenValuedGrandparent
    {
        private static int _res = 0;
        
        public static int SumEvenGrandparent(TreeNode root)
        {
            GrandparentFinder(root, null, null);

            Console.WriteLine("result = " + _res);
            return _res;
        }

        private static void GrandparentFinder(TreeNode node, TreeNode parent, TreeNode grandparent)
        {
            if (node == null)
                return;

            if (grandparent != null && grandparent.val % 2 == 0)
            {
                _res += node.val;
            }

            if (node.left != null)
            {
                GrandparentFinder(node.left, node, parent);
            }

            if (node.right != null)
            {
                GrandparentFinder(node.right, node, parent);
            }
        }
    }
}