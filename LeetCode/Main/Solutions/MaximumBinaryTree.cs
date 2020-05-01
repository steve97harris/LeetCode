using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MaximumBinaryTree
    {
        static List<int> leftSubarray = new List<int>();
        static List<int> rightSubarray = new List<int>();
        public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            var root = new TreeNode(nums.Max());
            
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

            GenerateTree(root);
            
            DisplayNodes(root, "root");

            return root;
        }

        private static void GenerateTree(TreeNode root)
        {
            var indexOfLeft = 0;
            while (indexOfLeft <= leftSubarray.Count)
            {
                if (root != null)
                    root.left = new TreeNode(leftSubarray[indexOfLeft]);
                
                indexOfLeft++;
                if (root != null && root.left == null)
                    GenerateTree(root);
            }
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