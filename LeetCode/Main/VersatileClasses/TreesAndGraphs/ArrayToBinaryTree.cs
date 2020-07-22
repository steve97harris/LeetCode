namespace LeetCode.Main.VersatileClasses.TreesAndGraphs
{
    public class ArrayToBinaryTree
    {
        public TreeNode ArrayToBt(int[] nums, TreeNode root, int i)
        {
            if (i >= nums.Length) 
                return root;

            TreeNode temp = null;
            
            if (nums[i] != -1)
                temp = new TreeNode(nums[i]);

            root = temp;

            if (root == null) 
                return null;
            
            root.left = ArrayToBt(nums, root.left, 2 * i + 1);
            root.right = ArrayToBt(nums, root.right, 2 * i + 2);

            return root; 
        }
    }
}