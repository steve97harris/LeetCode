using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class KidsWithTheGreatestNumberOfCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            var maxCandies = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                var isGreaterOrEqualMax = candies[i] + extraCandies >= maxCandies;
                result.Add(isGreaterOrEqualMax);
            }

            return result;
        }
    }
}