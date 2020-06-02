using LeetCode.Main.VersatileClasses;

namespace LeetCode.Main
{
    public static class InvertBinaryTree
    {
        private static TreeNode _root;
        public static TreeNode InvertTree(TreeNode root)
        {
            _root = root;
            Helper(root);
            
            root.Print();

            return root;
        }

        private static void Helper(TreeNode node)
        {
            if (node == null)
                return;
            
            if (node.left != null && node.right != null)
            {
                var tempL = node.left;
                var tempR = node.right;
                node.right = tempL;
                node.left = tempR;
            }
            if (node.left != null && node.right == null)
            {
                node.right = new TreeNode(node.left.val);
                // remove left node
            }
            if (node.left == null && node.right != null)
            {
                node.left = new TreeNode(node.right.val);
                // remove right node
            }
                
            if (node.left != null)
                Helper(node.left);
            if (node.right != null)
                Helper(node.right);
        }
    }
}