using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MovingZeroesToEnd
    {
        public static void MoveZeroes(int[] nums)
        {
            List<int> numsList = new List<int>();
            List<int> zerosList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zerosList.Add(nums[i]);
                }
                else
                {
                    numsList.Add(nums[i]);
                }
            }

            int[] result = numsList.Concat(zerosList).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = result[i];
                Console.WriteLine(nums[i]);
            }
        }
    }
}