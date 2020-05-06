using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class TheMajorityElement
    {
        public static int MajorityElement(int[] nums)
        {
            var majorityElement = 0;
            var count = new int[10];

            for (int i = 0; i < count.Length; i++)
            { 
                count[nums[i]] += 1;
                if (count[i] > majorityElement)
                    majorityElement = count[i];
            }

            
            Console.WriteLine(majorityElement);
            return majorityElement;
        }
    }
}