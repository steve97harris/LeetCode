using System;

namespace LeetCode.Main
{
    public static class NumberOf1Bits
    {
        public static int HammingWeight(uint n)
        {
            var count = 0;
            var stringN = new string(n.ToString());
            Console.WriteLine(stringN);
            
            foreach (var t in stringN)
            {
                if (t == '1')
                    count++;
            }

            Console.WriteLine(count);
            return count;
        }
    }
}