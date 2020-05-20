using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace LeetCode.Main.Solutions
{
    public static class ReversingIntegerDigits
    {
        public static int ReverseInt(int x)
        {
            if (x < -2147483647)
                return 0;
            var neg = false;
            if (x < 0)
            {
                x = Math.Abs(x);
                neg = true;
            }
            
            var xString = x.ToString();
            var xArray = xString.ToArray();
            for (int i = 0; i < xArray.Length / 2; i++)
            {
                var temp = xArray[i];
                xArray[i] = xString[xString.Length - 1 - i];
                xArray[xString.Length - 1 - i] = temp;
            }

            var stringResult = string.Join("", xArray);

            var res = BigInteger.Parse(stringResult);
            if (res > 2147483647)
                return 0;
            
            if (neg)
            {
                return (int) -res;
            }
            
            return (int) res;
        }
    }
}