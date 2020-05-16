using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ContainsDuplicates
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return false;

            var sorted = nums.ToList();
            sorted.Sort();

            for (int i = 0; i < sorted.Count; i++)
            {
                if (nums[i] == nums[i + 1])
                    return true;
            }

            return false;
        }
    }
}