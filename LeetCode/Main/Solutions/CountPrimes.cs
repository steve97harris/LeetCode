using System;

namespace LeetCode.Main
{
    public static class CountDePrimes
    {
        public static int CountPrimes(int n)
        {
            var count = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                    count++;
            }

            return count;
        }

        private static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;
            var boundary = (int) Math.Floor(Math.Sqrt(num));
            for (int i = 3; i <= boundary; i+= 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}