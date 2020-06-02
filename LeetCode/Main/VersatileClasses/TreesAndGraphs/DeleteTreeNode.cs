namespace LeetCode.Main.VersatileClasses.TreesAndGraphs
{
    public static class DeleteTreeNode
    {
        private static TreeNode root = new TreeNode();
        
        public static void DeleteNode(int val)
        {
            root = DeleteNodeHelper(root, val);
        }
        private static TreeNode DeleteNodeHelper(TreeNode node, int val)
        {
            if (node == null)
                return null;

            if (val < node.val)
                node.left = DeleteNodeHelper(node.left, val);
            if (val > node.val)
                node.right = DeleteNodeHelper(node.right, val);

            if (node.left == null)
                return node.right;
            if (node.right == null)
                return node.left;

            node.val = MinValue(node.right);
            node.right = DeleteNodeHelper(node.right, node.val);

            return node;
        }

        private static int MinValue(TreeNode node)
        {
            var minV = node.val;
            while (node.left != null)
            {
                minV = node.left.val;
                node = node.left;
            }

            return minV;
        }
    }
}