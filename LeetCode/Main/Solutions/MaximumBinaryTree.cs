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

            while (leftSubarray.Count != 0)
            {
                GenerateTreeLeft(root);
            }

            return root;
        }

        private static void GenerateTreeLeft(TreeNode root)
        {
            root.left = new TreeNode(leftSubarray[0]);
                
            leftSubarray.Remove(leftSubarray[0]);
                
            GenerateTreeLeft(root.left);
        }
    }
}