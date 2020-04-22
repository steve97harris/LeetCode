using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LeetCode.Main
{
    public static class SubArraySumEqualsK
    {
        private static List<int[]> subArrays = new List<int[]>();
        public static int SubarraySum(int[] nums, int k)
        {
            SubArrays(nums, 0,0, k);

            Console.WriteLine(subArrays.Count);
            return subArrays.Count;
        }

        private static void SubArrays(int[] arr, int start, int end, int targetSum)
        {
            if (end == arr.Length)
                return;
            
            if (start > end)
                SubArrays(arr, 0, end + 1, targetSum);
            else
            {
                var list = new List<int>();
                for (int i = start; i < end; i++)
                {
                    list.Add(arr[i]);
                }
                list.Add(arr[end]);

                if (list.Sum() == targetSum)
                {
                    subArrays.Add(list.ToArray());
                }
                SubArrays(arr,start + 1, end, targetSum);
            }
        }
    }
}