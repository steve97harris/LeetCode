using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class IntersectionOfTwoArrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var intersect = nums1.Intersect(nums2);
            return intersect.ToArray();
        }
    }
}