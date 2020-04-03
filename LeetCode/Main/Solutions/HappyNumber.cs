using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            List<int> cache = new List<int>();
            int sum = 0;
            while (n != 1)
            {
                if (cache.Contains(n))
                {
                    return false;
                }
                cache.Add(n);
                while (n != 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }
                n = sum;
                sum = 0;
            }
            return true;   
        }
    }
}