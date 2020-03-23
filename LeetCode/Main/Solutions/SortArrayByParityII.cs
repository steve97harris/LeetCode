using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class SortArrayByParityII
    {
        public static int[] SortByParityII(int[] A)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            List<int> result = new List<int>();
            
            for (int i = 0; i < A.Length; i++)
            {
                if (IsEven(A[i]))
                {
                    evens.Add(A[i]);
                }
                else
                {
                    odds.Add(A[i]);
                }
            }
            
            for (int i = 0; i < Math.Max(evens.Count,odds.Count); i++)
            {
                result.Add(evens[i]);
                result.Add(odds[i]);
            }

            A = result.ToArray();

            return A;
        }
        
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}