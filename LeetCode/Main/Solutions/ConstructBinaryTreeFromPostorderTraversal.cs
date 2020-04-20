using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class ConstructBinaryTreeFromPostorderTraversal
    {
        public static TreeNode BstFromPreorder(int[] preorder)
        {
            var root = PreorderTraversal(preorder, 0, preorder.Length - 1);
            
            return root;
        }

        private static TreeNode PreorderTraversal(int[] preorder, int start, int end)
        {
            if (preorder.Length <= start || start > end)
            {
                return null;
            }
            
            var root = new TreeNode(preorder[start]);

            var lastOne = start;
            for (int i = start; i <= end; i++)
            {
                if (preorder[i] > root.val)
                {
                    break;
                }

                lastOne = i;
            }

            root.left = PreorderTraversal(preorder, start + 1, lastOne);
            root.right = PreorderTraversal(preorder, lastOne + 1, end);

            return root;
        }
    }
}