using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class MaxDifferenceBetweenNodeAndAncestor
    {
        private List<int> leftSubtree = new List<int>();
        private List<int> rightSubtree = new List<int>();
        
        public int MaxAncestorDiff(TreeNode root)
        {
            leftSubtree.Add(root.val);
            rightSubtree.Add(root.val);
            
            Rec(root.left, leftSubtree);
            Rec(root.right, rightSubtree);
            
            var lefDiff = leftSubtree.Max() - leftSubtree.Min();
            var rightDiff = rightSubtree.Max() - rightSubtree.Min();
            var res = Math.Max(lefDiff, rightDiff);

            Console.WriteLine(lefDiff);
            Console.WriteLine(rightDiff);
            // Console.WriteLine(res);
            return res;
        }

        private void Rec(TreeNode node, List<int> values)
        {
            if (node == null)
                return;

            values.Add(node.val);
            
            if (node.left != null)
                Rec(node.left, values);
            if (node.right != null)
                Rec(node.right, values);
        }
    }
}