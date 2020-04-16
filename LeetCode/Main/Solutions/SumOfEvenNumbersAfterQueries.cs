using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SumOfEvenNumbersAfterQueries
    {
        public static int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var result = new List<int[]>();
            foreach (var array in queries)
            {
                var val = array[0];
                var index = array[1];
                A[index] += val;
                result.Add(A);
            }

            foreach (var array in result)
            {
                Console.WriteLine("---");
                foreach (var i in array)
                {
                    Console.WriteLine(i);
                }
            }
            // A = result.ToArray();
            return A;
        }
        
        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}