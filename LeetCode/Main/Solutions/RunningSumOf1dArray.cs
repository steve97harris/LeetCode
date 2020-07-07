using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class RunningSumOf1dArray
    {
        public static int[] RunningSum(int[] nums)
        {
            var currSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];
                nums[i] = currSum;
            }

            return nums;
        }
    }
}