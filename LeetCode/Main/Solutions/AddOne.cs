using System;
using System.Collections.Generic;
using System.Numerics;

namespace LeetCode.Main
{
    public static class AddOne
    {
        public static int[] PlusOne(int[] digits)
        {
            var num = BigInteger.Parse(string.Join("", digits)) + 1;
            var str = num.ToString();
            var result = new int[str.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(str[i].ToString());
            }

            return result;
        }
    }
}