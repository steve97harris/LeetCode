using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MaximumBinaryTree
    {
        public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            TreeNode root = null;

            for (int i = 0; i < nums.Length; i++)
            {
                root = NewNode(root, new TreeNode(nums[i]));
            }

            GetTreeNodeLevels.GetLevels(root);

            return root;
        }

        private static TreeNode NewNode(TreeNode node, TreeNode newNode)
        {
            if (node == null)
                return newNode;

            if (newNode.val > node.val)
            {
                newNode.left = node;
                return newNode;
            }

            // if (node.right == null)
            //     node.right = newNode;
            // else
            //     node.right = NewNode(node.right, newNode);

            node.right = node.right == null ? newNode : NewNode(node.right, newNode);


            return node;
        }

        private static TreeNode DisplayNode(TreeNode node, string leftRight)
        {
            // if (node == null)
            //     return null;
            
            if (node != null)
                Console.WriteLine($"{leftRight} - " + node.val);

            if (node?.left != null)
            {
                DisplayNode(node.left, "L");
            }

            if (node?.right != null)
            {
                DisplayNode(node.right, "R");
            }

            return node;
        }
    }
}