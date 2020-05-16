using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class RotateDeArray
    {
        public static void Rotate(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                nums = ShiftRight(nums);
            }

            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
        
        private static int[] ShiftRight(int[] arr)
        {
            var demo = new int[arr.Length];

            for (int i = 1; i < arr.Length; i++) 
            {
                demo[i] = arr[i - 1];
            }

            demo[0] = arr[demo.Length - 1];

            return demo;
        }
    }
}