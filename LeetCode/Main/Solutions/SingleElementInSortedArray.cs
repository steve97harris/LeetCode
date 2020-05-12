using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SingleElementInSortedArray
    {
        public static int SingleNonDuplicate(int[] nums)
        {
            var numberCount = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numberCount.ContainsKey(nums[i]))
                    numberCount.Add(nums[i], 1);
                else
                    numberCount[nums[i]] += 1;
            }

            var result = numberCount.Select(x => x).Where(x => x.Value == 1).ToArray();
            return result[0].Key;
        }
    }
}