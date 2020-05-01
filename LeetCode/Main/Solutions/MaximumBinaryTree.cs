using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MaximumBinaryTree
    {
        private static TreeNode head;
        static List<int> leftSubarray = new List<int>();
        static List<int> rightSubarray = new List<int>();
        public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            var root = new TreeNode(nums.Max());
            head = root;
            
            var indexOfNumsMax = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums.Max())
                    indexOfNumsMax = i;
            }

            for (int i = 0; i < indexOfNumsMax; i++)
            {
                leftSubarray.Add(nums[i]);
            }
            for (int i = indexOfNumsMax + 1; i < nums.Length; i++)
            {
                rightSubarray.Add(nums[i]);
            }
            leftSubarray.Sort();
            leftSubarray.Reverse();
            rightSubarray.Sort();
            rightSubarray.Reverse();

            GenerateTreeLeft(root);
            GenerateTreeRight(root);
            
            DisplayNodes(root, "root");

            return root;
        }
        
        private static void GenerateTreeLeft(TreeNode root)
        {
            if (root == null || leftSubarray.Count == 0) return;
            
            if (head.left == null)
                root.left = new TreeNode(leftSubarray[0]);
            else
                root.right = new TreeNode(leftSubarray[0]);
            
            leftSubarray.Remove(leftSubarray[0]);
            
            GenerateTreeLeft(root.left);
        }
        
        private static void GenerateTreeRight(TreeNode root)
        {
            if (root == null || rightSubarray.Count == 0) return;
            
            if (head.right == null)
                root.right = new TreeNode(rightSubarray[0]);
            else
                root.left = new TreeNode(rightSubarray[0]);
            
            rightSubarray.Remove(rightSubarray[0]);
            
            GenerateTreeRight(root.right);
        }

        private static TreeNode DisplayNodes(TreeNode root, string leftRight)
        {
            if (root == null)
                return null;
            Console.WriteLine($"{leftRight} - " + root.val);

            if (root.left != null)
            {
                DisplayNodes(root.left, "L");
            }

            if (root.right != null)
            {
                DisplayNodes(root.right, "R");
            }

            return root;
        }
    }
}