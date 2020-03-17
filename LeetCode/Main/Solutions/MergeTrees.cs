using System;

namespace LeetCode.Main.Solutions
{
    public static class MergeTrees
    {
        public static TreeNode MergeTreeNodes(TreeNode t1, TreeNode t2)
        {

            TreeNode t3;
            if (t1 != null && t2 != null)        // both have values
            {
                t3 = new TreeNode(t1.val + t2.val);
                t3.left = MergeTreeNodes(t1.left, t2.left);
                t3.right = MergeTreeNodes(t1.right, t2.right);
            }
            else if (t2 != null)        // t2 has a value
            {
                t3 = new TreeNode(t2.val);
                t2.left = MergeTreeNodes(null, t2.left);
                t2.right = MergeTreeNodes(null, t2.right);
                return t2;
            }
            else if (t1 != null)        // t1 has a value
            {
                t3 = new TreeNode(t1.val);
                t1.left = MergeTreeNodes(t1.left, null);
                t1.right = MergeTreeNodes(t1.right, null);
                return t1;
            }
            else         // both null
            {
                t3 = null;
            }

            return t3;
        }
    }
}