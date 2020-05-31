using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class TheThreeSum
    {
        private static IList<IList<int>> res = new List<IList<int>>();
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            GetThreeNums(nums);
            return res;
        }

        private static void GetThreeNums(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                var left = i + 1;
                var right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[left] + nums[right] + nums[i] == 0)
                    {
                        res.Add( new List<int>() {nums[left], nums[right], nums[i]});

                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right + 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (nums[left] + nums[right] + nums[i] < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

                while (i < nums.Length - 1 && nums[i] == nums[i+1])
                {
                    i++;
                }
            }
        }
    }
}