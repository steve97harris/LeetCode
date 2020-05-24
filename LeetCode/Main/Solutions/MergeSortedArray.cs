using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.VersatileClasses
{
    public static class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var temp = new List<int>();
            
            for (int i = 0; i < m; i++)
            {
                temp.Add(nums1[i]);
            }
            for (int i = 0; i < n; i++)
            {
                temp.Add(nums2[i]);
            }
            temp.Sort();
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = temp[i];
            }

            foreach (var i in nums1)
            {
                Console.WriteLine(i);
            }
        }
    }
}