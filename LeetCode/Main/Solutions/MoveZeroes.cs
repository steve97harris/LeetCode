using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MoveZeroes
    {
        public static void MoveDemZeroes(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[count++] = nums[i];
                }
            }
            while (count < nums.Length)
                nums[count++] = 0;

            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}