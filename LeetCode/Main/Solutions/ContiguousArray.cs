using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ContiguousArray
    {
        public static int FindMaxLength(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            int count = 0;
            int maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    count++;
                if (nums[i] == 1)
                    count--;

                if (dictionary.ContainsKey(count))
                    maxLength = Math.Max(maxLength, i - dictionary[count]);
                else
                    dictionary[count] = i;

                if (count == 0)
                    maxLength = i + 1;
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0},{1}",pair.Key,pair.Value);
            }
            
            return maxLength;
        }
    }
}