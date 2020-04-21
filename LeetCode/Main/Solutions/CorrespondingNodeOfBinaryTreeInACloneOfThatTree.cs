using System;

namespace LeetCode.Main
{
    public static class CorrespondingNodeOfBinaryTreeInACloneOfThatTree
    {
        public static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            var x = GetOgTarget(original, target);
            Console.WriteLine(x.val);
            
            

            return cloned;
        }

        private static TreeNode GetOgTarget(TreeNode original, TreeNode target)
        {
            if (original == null)
                return null;
            if (original == target)
            {
                return original;
            }

            var goDownLeft = GetOgTarget(original.left, target);
            if (goDownLeft == target)
                return goDownLeft;
            
            var goDownRight = GetOgTarget(original.right, target);
            if (goDownRight == target)
                return goDownRight;

            return original;
        }
    }
}