using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ArrayPartitionI
    {
        public static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            List<int> result = new List<int>();
            int sumResult;

            for (int i = 0; i < nums.Length/2; i++)
            {
                int x = nums.Skip(i * 2).Take(2).Min();
                result.Add(x);
                Console.WriteLine(x);
            }

            sumResult = result.Sum();
            

            return sumResult;
        }
    }
}