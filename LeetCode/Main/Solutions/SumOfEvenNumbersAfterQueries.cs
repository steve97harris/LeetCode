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
            for (int i = 0; i < queries.Length; i++)
            {
                A[queries[i][1]] = queries[i][0];
                // Console.WriteLine(A[i]);
                
                var tempEvens = new List<int>();
                if (IsEven(A[i]))
                {
                    tempEvens.Add(A[i]);
                    Console.WriteLine(A[i]);
                }

                var sumOfEvens = tempEvens.Sum();
                //Console.WriteLine(sumOfEvens);
                result.Add(sumOfEvens);
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