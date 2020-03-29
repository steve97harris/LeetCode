using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MinAbsoluteDifference
    {
        public static IList<IList<int>> MinAbsDifference(int[] arr)
        {
            var result = new List<IList<int>>();

            if (arr == null || arr.Length < 2)
            {
                return new List<IList<int>>();
            }
            
            Array.Sort(arr);

            var minimums = new SortedSet<int>();
            var min = arr[arr.Length - 1] - arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                var diff = arr[i] - arr[i - 1];
                if (diff < min)
                {
                    min = diff;
                    minimums.Clear();
                    minimums.Add(i);
                }
                else if (diff == min)
                {
                    minimums.Add(i);
                }
            }

            foreach (var index in minimums)
            {
                result.Add(new List<int>(new int[] {arr[index - 1], arr[index]}));
            }

            return result;
        }
    }
}