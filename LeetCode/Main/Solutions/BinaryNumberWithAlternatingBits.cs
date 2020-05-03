using System;

namespace LeetCode.Main
{
    public static class BinaryNumberWithAlternatingBits
    {
        public static bool HasAlternatingBits(int n)
        {
            var nBaseTwo = Convert.ToString(n, 2);

            for (int i = 0; i < nBaseTwo.Length - 1; i++)
            {
                if (nBaseTwo[i] == nBaseTwo[i + 1])
                    return false;
            }
            return true;
        }
    }
}