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
            if (root == null)
            {
                root = new TreeNode(val);
                root.left = null;
                root.right = null;
            }
            else
            {
                var curr = root;
                
                while (curr != null)
                {
                    if (val < curr.val)
                        curr = curr.left;
                    else
                        curr = curr.right;
                }
                
                if (curr == null)
                    curr = new TreeNode(val);
                else if (val < curr.val)
                    curr.left = new TreeNode(val);
                else
                    curr.right = new TreeNode(val);
            }
        }
    }
}