using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class HouseRobber
    {
        public static int Rob(int[] nums)
        {
            switch (nums.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return nums[0];
                case 2:
                    return Math.Max(nums[0], nums[1]);
            }

            var i2 = 0;        // index - 2
            var i1 = 0;        // index - 1
            for (int i = 0; i < nums.Length; i++)
            {
                var max = Math.Max(nums[i] + i2, i1);
                i2 = i1;
                i1 = max;
            }
            
            return Math.Max(i1,i2);
        }
    }
}