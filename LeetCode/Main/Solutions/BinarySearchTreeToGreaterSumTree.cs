using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class BinarySearchTreeToGreaterSumTree
    {
        private static int previousNodeVal = 0;
        private static List<int> allNodeValues = new List<int>();
        private static List<int> valuesGreaterOrEqualToCurrent = new List<int>();
        public static TreeNode BstToGst(TreeNode root)
        {
            TreeNode result = new TreeNode(0);
            if (root != null)
            {
                result = NewNodeValue(root);
                Console.WriteLine(result);
            }

            if (root?.left != null)
            {
                BstToGst(root.left);
            }
            
            if (root?.right != null)
            {
                BstToGst(root.right);
            }
            
            return result;
        }

        private static void ReturnValuesGreaterOrEqualToCurrent(TreeNode node)
        {
            if (node != null && !allNodeValues.Contains(node.val))
                allNodeValues.Add(node.val);
            
            if (node != null && node.val >= previousNodeVal)
            {
                valuesGreaterOrEqualToCurrent.Add(node.val);
            }

            if (node?.left != null)
            {
                ReturnValuesGreaterOrEqualToCurrent(node.left);
            }

            if (node?.right != null)
            {
                ReturnValuesGreaterOrEqualToCurrent(node.right);
            }
        }

        private static TreeNode NewNodeValue(TreeNode node)
        {
            previousNodeVal = node.val;
            ReturnValuesGreaterOrEqualToCurrent(node);

            var x = allNodeValues.Select(i => i).Where(i => i >= node.val).ToList();
            foreach (var i in x.Where(i => !valuesGreaterOrEqualToCurrent.Contains(i)))
            {
                valuesGreaterOrEqualToCurrent.Add(i);
            }

            var sumOfValues = valuesGreaterOrEqualToCurrent.Sum();
            node.val = sumOfValues;

            Console.WriteLine("---");
            foreach (var i in valuesGreaterOrEqualToCurrent)
            {
                Console.WriteLine(i);
            }
            valuesGreaterOrEqualToCurrent.Clear();

            Console.WriteLine("NewNodeVal = " + node.val + " (sumOfValues)");
            return node;
        }
    }
}