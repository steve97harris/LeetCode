namespace LeetCode.Main.Solutions
{
    public static class SearchInBinaryTree
    {
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            TreeNode result = new TreeNode(0);

            if (root.val == val)
            {
                result = new TreeNode(root.val);
                result.left = SearchBST(root.left, root.left.val);
                result.right = SearchBST(root.right, root.right.val);
            }
            else if (root.left.val == val)
            {
                result = new TreeNode(root.left.val);
                result.left = SearchBST(result.left, result.left.val);
                result.right = SearchBST(result.right, result.right.val);
            }
            else if (root.right.val == val)
            {
                result = new TreeNode(root.right.val);
                result.left = SearchBST(result.left, result.left.val);
                result.right = SearchBST(result.right, result.right.val);
            }
            else
            {
                return null;
            }

            return result;
        }
    }
}