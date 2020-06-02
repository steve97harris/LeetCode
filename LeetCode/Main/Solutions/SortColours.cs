using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class SortDeColours
    {
        public static void SortColours(int[] nums)
        {
            var map = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else
                    map.Add(nums[i], 1);
            }

            for (int i = 0; i < 3; i++)
            {
                UpdateNums(nums,map,i);
            }

            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }

        private static int j;
        private static void UpdateNums(int[] nums, Dictionary<int,int> map, int key)
        {
            if (!map.ContainsKey(key)) 
                return;
            
            for (int i = 0; i < map[key]; i++)
            {
                nums[j] = key;
                j++;
            }
        }
    }
}