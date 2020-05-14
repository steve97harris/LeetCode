namespace LeetCode.Main.Solutions
{
    public static class SearchInBinaryTree
    {
        private static TreeNode node = new TreeNode();
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            SearchHelper(root,val);
            return node;
        }

        private static void SearchHelper(TreeNode root, int val)
        {
            if (root == null)
                return;

            if (root.val == val)
                node = root;
            
            if (root.left != null)
                SearchHelper(root.left,val);
            
            if (root.right != null)
                SearchHelper(root.right, val);
        }
    }
}