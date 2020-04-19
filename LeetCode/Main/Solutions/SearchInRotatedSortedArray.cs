using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class SearchInRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            var targetIndex = 0;

            if (nums == null)
            {
                targetIndex = -1;
                return targetIndex;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    targetIndex = i;
                else if (!nums.Contains(target))
                    targetIndex = -1;
            }

            return targetIndex;
        }
    }
}