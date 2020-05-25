using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class BestTimeToBuyAndSellStock
    {
        private static int maxProfit;
        private static List<int> pricesList;
        private static int midIndex;
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            
            pricesList = prices.ToList();
            var minPrice = prices.Min();
            var maxPrice = prices.Max();

            midIndex = prices.Length / 2;
            Console.WriteLine("midIndex = " + midIndex);

            ProfitCalculator(prices, minPrice, maxPrice);
            Console.WriteLine("maxProfit = " + maxProfit);
            return maxProfit;
        }

        private static void ProfitCalculator(int[] prices, int minPrice, int maxPrice)
        {
            var minPriceIndex = 0;
            var maxPriceIndex = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] == minPrice)
                {
                    minPriceIndex = i;
                }

                if (prices[i] == maxPrice)
                {
                    maxPriceIndex = i;
                }
            }

            
            
            if (minPriceIndex < maxPriceIndex)
            {
                maxProfit = maxPrice - minPrice;
            }
            else
            {
                if (minPriceIndex == maxPriceIndex)
                    return;
                
                if (maxPriceIndex < midIndex)
                    pricesList.Remove(maxPrice);
                if (minPriceIndex > midIndex)
                    pricesList.Remove(minPrice);
                
                if (pricesList.Count == 0) 
                    return;
                
                maxPrice = pricesList.Max();
                minPrice = pricesList.Min();
                Console.WriteLine("maxPrice = " + maxPrice);
                Console.WriteLine("minPrice = " + minPrice);
                ProfitCalculator(prices, minPrice, maxPrice);
            }
        }
    }
}