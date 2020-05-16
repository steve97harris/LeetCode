using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class IntersectionOfTwoArraysII
    {
        private static List<int> list = new List<int>();
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                Compare(nums1,nums2);
            }
            else
                Compare(nums2, nums1);

            return list.ToArray();
        }

        private static void Compare(int[] largeArr, int[] smallArr)
        {
            var j = 0;
            for (int i = 0; i < largeArr.Length; i++)
            {
                while (smallArr[j] == largeArr[i])
                {
                    list.Add(smallArr[j]);
                    j++;
                    i++;
                }
            }

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}