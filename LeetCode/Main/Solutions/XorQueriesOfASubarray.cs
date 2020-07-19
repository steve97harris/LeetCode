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
                var xor = 0;
                if (i >= 1 && queries[i] == queries[i - 1])
                {
                    res.Add(res[^1]);
                }
                else
                {
                    for (int j = queries[i][0]; j <= queries[i][1]; j++)
                    {
                        xor ^= arr[j];
                    }
                    res.Add(xor);
                }
            }

            return res.ToArray();
        }
    }
}