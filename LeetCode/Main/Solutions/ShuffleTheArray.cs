using System.Collections.Generic;

namespace LeetCode.Main
{
    public class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var l1 = new List<int>();
            var l2 = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < n)
                    l1.Add(nums[i]);
                else
                    l2.Add(nums[i]);
            }
            
            var res = new List<int>();
            for (int i = 0; i < l1.Count; i++)
            {
                res.Add(l1[i]);
                res.Add(l2[i]);
            }

            return res.ToArray();
        }
    }
}