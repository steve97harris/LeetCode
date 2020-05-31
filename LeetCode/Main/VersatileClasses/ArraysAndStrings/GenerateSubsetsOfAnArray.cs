using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.VersatileClasses
{
    public static class GenerateSubsetsOfAnArray
    {
        private static List<int[]> allSubsets = new List<int[]>();
        public static void Subsets(int[] arr, int k)
        {
            var subset = new int[k];
            SubsetHelper(arr,subset,0,arr.Length - 1,0,k);
            
            PrintSubsets();
        }

        private static void SubsetHelper(int[] arr, int[] data, int start, int end, int currIndex, int k)
        {
            if (currIndex == k)
            {
                var set = new int[k];
                for (int i = 0; i < k; i++)
                {
                    set[i] = data[i];
                }

                if (!allSubsets.Contains(set))
                {
                    allSubsets.Add(set);
                    return;
                }
            }

            for (int i = start; i <= end && end - i + 1 >= k - currIndex; i++)
            {
                data[currIndex] = arr[i];
                SubsetHelper(arr,data,i+1,end,currIndex+1,k);
            }
        }

        private static void PrintSubsets()
        {
            foreach (var stringArr in allSubsets.Select(arr => string.Join(" ", arr)))
            {
                Console.WriteLine(stringArr);
                Console.WriteLine("-----");
            }
        }
    }
}