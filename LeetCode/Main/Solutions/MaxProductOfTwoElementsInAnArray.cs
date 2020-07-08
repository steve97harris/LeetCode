namespace LeetCode.Main.Solutions
{
    public class MaxProductOfTwoElementsInAnArray
    {
        public static int MaxProduct(int[] nums)
        {
            var maxVal = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    var currVal = (nums[i] - 1) * (nums[j] - 1);
                    if (currVal > maxVal && i != j)
                    {
                        maxVal = currVal;
                    }
                }
            }

            return maxVal;
        }
    }
}