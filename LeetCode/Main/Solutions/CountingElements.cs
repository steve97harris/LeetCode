using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class CountingElements
    {
        public static int CountElements(int[] arr)
        {
            var countedNumbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i] + 1;

                if (arr.Contains(temp))
                {
                    countedNumbers.Add(arr[i]);
                }
            }

            return countedNumbers.Count;
        }
    }
}