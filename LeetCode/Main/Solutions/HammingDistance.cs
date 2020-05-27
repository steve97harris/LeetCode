using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class HammingDeDistance
    {
        public static int HammingDistance(int x, int y)
        {
            var xBits = ConvertToBits(x);
            var yBits = ConvertToBits(y);

            var count = xBits.Where((t, i) => t != yBits[i]).Count();
            
            Console.WriteLine(count);
            return count;
        }

        private static int[] ConvertToBits(int num)
        {
            var s = Convert.ToString(num, 2);
            Console.WriteLine(s);

            var bits = s.PadLeft(100, '0')
                .Select(c => int.Parse(c.ToString())).ToArray();

            return bits;
        }
    }
}