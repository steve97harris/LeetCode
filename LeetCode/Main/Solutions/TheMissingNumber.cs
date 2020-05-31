using System;
using System.Linq;

namespace LeetCode.Main
{
    public static class TheMissingNumber
    {
        private static int result;
        public static int MissingNumber(int[] nums)
        {
            RetrieveMissingNum(nums,nums.Length);
            Console.WriteLine(result);
            return result;
        }

        private static void RetrieveMissingNum(int[] nums, int x)
        {
            while (true)
            {
                if (x < 0) 
                    return;

                if (!nums.Contains(x))
                {
                    result = x;
                    return;
                }

                x--;
            }
        }
    }
}