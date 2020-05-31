using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class ListOfTreeNodes
    {
        private static List<TreeNode> allNodeValues = new List<TreeNode>();
        private static List<TreeNode> SearchTree(TreeNode root)
        {
            if (root == null)
                return null;

            if (!allNodeValues.Contains(root))
            {
                allNodeValues.Add(root);
            }

            if (root.left != null)
            {
                SearchTree(root.left);
            }

            if (root.right != null)
            {
                SearchTree(root.right);
            }

            return allNodeValues;
        }
    }
}