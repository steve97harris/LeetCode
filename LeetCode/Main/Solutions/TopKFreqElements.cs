using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class TopKFreqElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else 
                    map.Add(nums[i], 1);
            }
            
            var result = new List<int>();
            for (int i = 0; i < k; i++)
            {
                var keyOfMaxValue = map.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                result.Add(keyOfMaxValue);
                map.Remove(keyOfMaxValue);
            }

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            return result.ToArray();
        }
    }
}