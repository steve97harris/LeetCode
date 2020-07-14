using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class KthFactorOfN
    {
        public static int KthFactor(int n, int k)
        {
            var factors = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    factors.Add(i);
            }
            factors.Add(n);

            if (k > factors.Count)
                return -1;

            Console.WriteLine(factors[k-1]);
            return factors[k - 1];
        }
    }
}