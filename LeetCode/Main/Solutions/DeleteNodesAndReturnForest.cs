using System.Collections.Generic;

namespace LeetCode.Main
{
    public class DeleteNodesAndReturnForest
    {
        IList<TreeNode> res = new List<TreeNode>();
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            Rec(root, to_delete);

            return res;
        }

        public void Rec(TreeNode node, int[] arr)
        {
            if (node == null)
                return;

            for (int i = 0; i < arr.Length; i++)
            {
                if (node.val == arr[i])
                {
                    // ?
                }
            }

            if (node.left != null)
                Rec(node.left, arr);
            if (node.right != null)
                Rec(node.right, arr);
        }
    }
}