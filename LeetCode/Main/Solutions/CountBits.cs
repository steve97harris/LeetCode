using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class CountingBits
    {
        public static int[] CountBits(int num)
        {
            var result = new List<int>();
            for (int i = 0; i <= num; i++)
            {
                var numBase2 = ConvertToBits(i);
                var currCount = numBase2.Count(t => t == 1);
                result.Add(currCount);
            }
            
            return result.ToArray();
        }

        private static int[] ConvertToBits(int num)
        {
            var s = Convert.ToString(num, 2);

            var bits = s.PadLeft(8, '0')
                .Select(c => int.Parse(c.ToString())).ToArray();

            return bits;
        }
    }
}