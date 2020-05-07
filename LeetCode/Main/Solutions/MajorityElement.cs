using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class TheMajorityElement
    {
        public static int MajorityElement(int[] nums)
        {
            var maxFreq = 0;
            var majorityElement = 0;
            var countDic = new Dictionary<int,int>();    
            // {number, count}
            for (int i = 0; i < nums.Length; i++)
            {
                if (countDic.ContainsKey(nums[i]))
                {
                    countDic[nums[i]] += 1;
                }
                else
                {
                    countDic.Add(nums[i],1);
                }

                if (maxFreq >= countDic[nums[i]]) continue;
                maxFreq = countDic[nums[i]];
                majorityElement = nums[i];
            }

            Console.WriteLine(majorityElement);
            return majorityElement;
        }
    }
}