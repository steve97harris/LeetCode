using System;

namespace LeetCode.Main.Solutions
{
    public static class SmallerThanCurrent
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] count = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i] && i != j)
                    {
                        ++count[i];
                    }
                }
            }

            foreach (int x in count)
            {
                Console.WriteLine(x);
            }

            return nums;
        }
    }
}