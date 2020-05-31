using System;
using System.Linq;
using LeetCode.Main.VersatileClasses;

namespace LeetCode.Main
{
    public static class SortedArrayToBinarySearchTree
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            var root = InsertNode(nums, 0, nums.Length - 1);
            root.Print();
            return root;
        }

        private static TreeNode InsertNode(int[] nums, int left, int right)
        {
            if (right < left)
                return null;
            
            var mid = (left + right) / 2;
            
            var root = new TreeNode(nums[mid]);
            root.left = InsertNode(nums, left, mid - 1);
            root.right = InsertNode(nums, mid + 1, right);

            return root;
        }
    }
}