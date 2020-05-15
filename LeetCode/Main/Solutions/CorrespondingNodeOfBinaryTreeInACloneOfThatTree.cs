using System;

namespace LeetCode.Main
{
    public static class CorrespondingNodeOfBinaryTreeInACloneOfThatTree
    {
        private static TreeNode clone = new TreeNode();
        public static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            GetClone(cloned, target);
            return clone;
        }

        private static void GetClone(TreeNode node, TreeNode target)
        {
            if (node == null || target == null)
                return;

            if (node.val == target.val)
                clone = node;

            if (node.left != null)
                GetClone(node.left, target);

            if (node.right != null)
                GetClone(node.right, target);
        }
    }
}