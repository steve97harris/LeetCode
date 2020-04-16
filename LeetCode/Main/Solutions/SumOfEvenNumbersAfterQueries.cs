using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SumOfEvenNumbersAfterQueries
    {
        public static int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var result = new List<int>();
            var sumOfEvens = A.Where(IsEven).Sum();

            foreach (var t in queries)
            {
                var val = t[0];
                var index = t[1];

                if (IsEven(A[index]))
                    sumOfEvens -= A[index];
                
                A[index] = A[index] + val;

                if (IsEven(A[index]))
                    sumOfEvens += A[index];
                
                result.Add(sumOfEvens);
            }

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            
            A = result.ToArray();
            return A;
        }
        
        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}