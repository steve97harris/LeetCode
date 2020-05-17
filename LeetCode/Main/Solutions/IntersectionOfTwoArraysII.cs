using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class IntersectionOfTwoArraysII
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var dic = nums2.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            return nums1.Where(x => dic.ContainsKey(x) && dic[x]-- > 0).ToArray();
        }
    }
}