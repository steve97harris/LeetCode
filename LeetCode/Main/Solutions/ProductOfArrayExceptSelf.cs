using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int zeroCount = 0;
            int zeroIndex = -1;
            var product = 1;
            
            if (nums == null) return null;
            if (nums.Length == 0) return new int[0];
            if (nums.Length == 1) return new int[] { 0 };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    product *= nums[i];
                }
                else
                {
                    zeroIndex = i;
                    zeroCount++;
                }
            }

            if (zeroCount >= 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = 0;
                }

                if (zeroCount == 1)
                {
                    nums[zeroIndex] = product;
                }

                return nums;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = product / nums[i];
            }

            return nums;
        }
    }
}