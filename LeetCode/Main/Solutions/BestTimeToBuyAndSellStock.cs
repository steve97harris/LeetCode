using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var minPrice = prices.Min();
            var maxPrice = prices.Max();
            return ProfitCalculator(prices, minPrice, maxPrice);
        }

        private static int ProfitCalculator(int[] prices, int minPrice, int maxPrice)
        {
            var maxProfit = 0;

            var minPriceIndex = 0;
            var maxPriceIndex = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] == minPrice)
                    minPriceIndex = i;
                if (prices[i] == maxPrice)
                    maxPriceIndex = i;
            }

            if (minPriceIndex < maxPriceIndex)
                maxProfit = maxPrice - minPrice;
            else
            {
                // find new maxPrice?
                
                
                ProfitCalculator(prices, minPrice, maxPrice);
            }

            return maxProfit;
        }
    }
}