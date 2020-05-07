namespace LeetCode.Main
{
    public class BinaryTree
    {
        private int GetLevelHelper(TreeNode node, int val, int level)
        // Returns level of the value if the value exists in tree, otherwise returns 0;
        {
            if (node == null)
                return 0;
            if (node.val == val)
                return level;

            var downLevel = GetLevelHelper(node.left, val, level + 1);
            if (downLevel != 0)
                return downLevel;

            downLevel = GetLevelHelper(node.right, val, level + 1);
            return downLevel;
        }

        public int GetLevel(TreeNode node, int val)
        {
            return GetLevelHelper(node, val, 1);
        }
    }
}