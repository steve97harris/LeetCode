using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class MaximumSumCircularSubarray
    {
        public static int MaxSubarraySumCircular(int[] A)
        {
            if (A.Length == 0)
                return 0;

            var res = MaxSubArraySum(A);

            var left = new int[A.Length];
            var right = new int[A.Length];
            var maxLeft = new int[left.Length];
            var maxRight = new int[right.Length];

            left[A.Length - 1] = maxLeft[A.Length - 1] = A[A.Length - 1];

            for (int i = A.Length - 2; i >= 0 ; i--)
            {
                left[i] = left[i + 1] + A[i];
                maxLeft[i] = Math.Max(left[i], maxLeft[i + 1]);
            }

            right[0] = maxRight[0] = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                right[i] = right[i - 1] + A[i];
                maxRight[i] = Math.Max(maxRight[i - 1], right[i]);
            }

            for (int i = 0; i < A.Length; i++)
            {
                res = Math.Max(res, maxLeft[i] + (i == 0 ? 0 : maxRight[i - 1]));
            }

            return res;
        }

        private static int MaxSubArraySum(int[] arr)
        {
            var cur = 0;
            var res = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                cur += arr[i];
                if (cur < arr[i])
                {
                    cur = arr[i];
                }

                res = Math.Max(cur, res);
            }
            return res;
        }
    }
}