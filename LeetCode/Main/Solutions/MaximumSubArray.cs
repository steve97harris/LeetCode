using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class MaximumSubArray
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxSoFar = int.MinValue, maxEndingHere = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                maxEndingHere += nums[i];

                if (maxEndingHere > maxSoFar)
                    maxSoFar = maxEndingHere;

                if (maxEndingHere < 0)
                    maxEndingHere = 0;
            }

            Console.WriteLine(maxSoFar);
            return maxSoFar;
        }
    }
}