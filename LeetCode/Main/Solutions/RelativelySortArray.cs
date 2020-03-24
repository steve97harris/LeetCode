using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class RelativelySortArray
    {
        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            List<int> leftOvers = new List<int>();

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        result.Add(arr1[j]);
                    }
                }
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!result.Contains(arr1[i]))
                {
                    leftOvers.Add(arr1[i]);
                }
            }
            
            leftOvers.Sort();
            result = result.Concat(leftOvers).ToList();

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            return arr1;
        }
    }
}