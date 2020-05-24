namespace LeetCode.Main
{
    public static class SortedArrayToBinarySearchTree
    {
        private static TreeNode root;
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            // { root, root.left, root.right, root.left.left, root.left.right, root.right.left, root.right.right }

            for (int i = 0; i < nums.Length; i++)
            {
                AddNode(nums[i]);
            }

            return root;
        }

        private static void AddNode(int val)
        {
            
        }
    }
}