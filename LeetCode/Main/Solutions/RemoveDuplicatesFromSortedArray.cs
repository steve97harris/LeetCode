using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)        // Actually moves non duplicates to front of array
        {
            var x = nums.Distinct().ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < x.Length)
                    nums[i] = x[i];
                else
                    nums[i] = -99;
            }
            
            return x.Length;
        }
    }
}