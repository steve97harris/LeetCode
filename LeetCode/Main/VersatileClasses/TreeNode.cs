using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public partial class TreeNode
    {
        public int val;
        public TreeNode left; 
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}