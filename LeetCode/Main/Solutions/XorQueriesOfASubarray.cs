using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class XorQueriesOfASubarray
    {
        public static int[] XorQueries(int[] arr, int[][] queries)
        {
            var res = new List<int>();
            for (int i = 0; i < queries.Length; i++)
            {
                var x = 0;
                // for (int j = queries[i][0]; j < queries[i][1]; j++)
                // {
                //     x ^= arr[j];
                //     Console.WriteLine(x);
                //     Console.WriteLine("arr: " + arr[j]);
                // }
                Console.WriteLine("res = " + x);
                res.Add(x);
            }

            var c = 1 ^ 3;
            Console.WriteLine("sdjklfhaiksdb =" + c);

            return res.ToArray();
        }
    }
}