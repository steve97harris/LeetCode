using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class CreateTargetArrayInGivenOrder
    {
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            Dictionary<int,int> dic = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], index[i]);
            }

            foreach (int xNum in nums)
            {
                Console.WriteLine(xNum);
            }

            return nums;
        }
    }
}