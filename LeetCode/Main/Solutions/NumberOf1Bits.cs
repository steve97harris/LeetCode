using System;
using System.Linq;

namespace LeetCode.Main
{
    public static class NumberOf1Bits
    {
        public static int HammingWeight(uint n)
        {
            var stringN = new string(n.ToString());
            Console.WriteLine(stringN);

            var count = stringN.Count(t => t == '1');

            Console.WriteLine(count);
            return count;
        }
    }
}