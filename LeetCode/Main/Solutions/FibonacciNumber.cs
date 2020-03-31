using System;

namespace LeetCode.Main
{
    public static class FibonacciNumber
    {
        public static int Fib(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine(a);
            return a;
        }
    }
}