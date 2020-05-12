using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class NextGreaterElementI
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = NGEHelper(nums2, nums1[i]);
                Console.WriteLine(nums1[i]);
            }

            return nums1;
        }

        private static int NGEHelper(int[] nums2, int num)
        {
            var indexOfNum = nums2.ToList().IndexOf(num);
            for (int i = indexOfNum; i < nums2.Length; i++)
            {
                if (nums2[i] > num)
                {
                    return nums2[i];
                }
            }

            return -1;
        }
    }
}