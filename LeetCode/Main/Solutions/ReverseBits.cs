using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ReverseDeBits
    {
        public static uint ReverseBits(uint n)
        {
            var x = ConvertToStringOfBits(n);
            var reverseX = new string(x.Reverse().ToArray());
            var res = uint.Parse(reverseX);
            return res;
        }
        
        private static string ConvertToStringOfBits(uint num)
        {
            var s = Convert.ToString(num, 2);
            Console.WriteLine(s);
            return s;
        }
    }
}