using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class CreateTargetArrayInGivenOrder
    {
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> result = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                result.Insert(index[i], nums[i]);
            }

            Console.WriteLine("result:");
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            return result.ToArray();
        }
    }
}