using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class CountNumberOfTeams
    {
        private static List<int[]> allSubsets = new List<int[]>();
        public static int NumTeams(int[] rating)
        {
            var indexRatings = new Dictionary<int, int>();        // {index, rating}
            for (int i = 0; i < rating.Length; i++)
            {
                indexRatings.Add(i, rating[i]);
            }
            
            GetSubsets(rating, rating.Length, 3);

            var validRatings = allSubsets.Where(subset => subset[0] < subset[1] && subset[1] < subset[2] || subset[0] > subset[1] && subset[1] > subset[2]).ToList();
            

            return 0;
        }

        private static void GetSubsets(int[] arr, int n, int r)
        {
            int[] allCombos = new int[r];
            SubsetHelper(arr, n, r, 0, allCombos, 0);
        }

        private static void SubsetHelper(int[] arr, int n, int r, int index, int[] data, int i)        // Gets current combination of integers
        {
            var list = new List<int>();
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                {
                    list.Add(data[j]);
                }
                allSubsets.Add(list.ToArray());
                return;
            }
            
            if (i >= n)
                return;

            data[index] = arr[i];
            SubsetHelper(arr, n, r, index + 1, data, i+1);
            
            SubsetHelper(arr, n, r, index, data, i+1);
        }
    }
}