using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ContiguousArray
    {
        public static int FindMaxLength(int[] nums)
        {
            var dictionary = new Dictionary<int,int>();
            var maxLength = 0;
            var count = 0;

            dictionary.Add(0,-1);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    count++;
                else
                    count--;

                if (dictionary.ContainsKey(count))
                {
                    var newLength = i - dictionary[count];
                    maxLength = Math.Max(maxLength, newLength);
                }
                else
                    dictionary.Add(count, i);
            }

            return maxLength;
        }
    }
}