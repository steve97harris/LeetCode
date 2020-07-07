using System;

namespace LeetCode.Main
{
    public static class XorOperationInAnArray
    {
        public static int XorOperation(int n, int start)
        {
            var res = 0;
            var nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = start + 2 * i;
                res ^= nums[i];
            }
            
            Console.WriteLine(res);
            return res;
        }
    }
}