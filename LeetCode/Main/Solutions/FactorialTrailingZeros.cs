using System;
using System.Linq;

namespace LeetCode.Main
{
    public static class FactorialTrailingZeros
    {
        public static int TrailingZeroes(int n)
        {
            if (n <= 0)
                return 0;

            int trailingZeros = 0;
            while (n > 0)
            {
                trailingZeros += n / 5;
                n /= 5;
            }

            return trailingZeros;
        }
    }
}