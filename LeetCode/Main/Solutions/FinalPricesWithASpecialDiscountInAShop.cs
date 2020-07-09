using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class FinalPricesWithASpecialDiscountInAShop
    {
        public static int[] FinalPrices(int[] prices)
        {
            var discountPrices = new List<int>();
            for (int i = 0; i < prices.Length; i++)
            {
                var nextSmallest = -1;
                for (int j = i+1; j < prices.Length; j++)
                {
                    if (prices[j] > prices[i]) 
                        continue;
                    
                    nextSmallest = prices[j];
                    break;
                }

                if (nextSmallest != -1)
                    discountPrices.Add(prices[i] - nextSmallest);
                else
                    discountPrices.Add(prices[i]);
            }

            return discountPrices.ToArray();
        }
    }
}