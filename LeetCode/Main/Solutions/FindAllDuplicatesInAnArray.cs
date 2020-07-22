using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public class FindAllDuplicatesInAnArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var res = new List<int>();
            var customMap = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                customMap[nums[i]]++;
                
                if (customMap[nums[i]] == 2)
                    res.Add(nums[i]);
            }
            
            // or
            // var map = new Dictionary<int,int>();
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (!map.ContainsKey(nums[i]))
            //         map.Add(nums[i], 1);
            //     else
            //     {
            //         map[nums[i]]++;
            //     }
            //     
            //     if (map[nums[i]] == 2)
            //         res.Add(nums[i]);
            // }

            return res;
        }
    }
}