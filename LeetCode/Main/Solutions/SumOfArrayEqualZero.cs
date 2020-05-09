using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class SumOfArrayEqualZero
    {
        public static int[] SumZero(int n)
        {
            var result = new int[n];
            var mid = n/2;

            if (n % 2 == 0)
            {
                for (int i = 0; i <= mid; i++)
                {
                    result[mid - i] = -i;
                }
                for (int i = 1; i < mid; i++)
                {
                    result[mid + i] = i;
                }
                result[n-1] -= result.Sum();
            }
            else
            {
                for (int i = 0; i <= mid; i++)
                {
                    result[mid + i] = i;
                    result[mid - i] = -i;
                }
            }
            
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            
            return result;
        }
    }
}