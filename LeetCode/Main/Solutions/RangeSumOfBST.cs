using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class RangeSumOfBst
    {
        private static int sum = 0;
        public static int RangeSumBst(TreeNode root, int L, int R)
        {
            if (root != null)
            {
                RangeSumBst(root.left, L, R);
                sum += (root.val >= L && root.val <= R) ? root.val : 0;
                RangeSumBst(root.right, L, R);
            }
            
            Console.WriteLine(sum);
            return sum;
        }
    }
}