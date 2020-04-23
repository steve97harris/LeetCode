using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class CountNumberOfTeams
    {
        public static int NumTeams(int[] rating)
        {
            var indexRatings = new Dictionary<int, int>();        // {index, rating}
            for (int i = 0; i < rating.Length; i++)
            {
                indexRatings.Add(i, rating[i]);
            }
            
            

            return 0;
        }
    }
}