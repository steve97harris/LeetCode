using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class RotateDeArray
    {
        public static void Rotate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var newIndex = 0;
                if (i + k < nums.Length)
                    newIndex = i + k;
                else
                    newIndex = i;
            }

            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}