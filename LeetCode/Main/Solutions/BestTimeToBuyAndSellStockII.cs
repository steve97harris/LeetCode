using System;

namespace LeetCode.Main.Solutions
{
    public static class BestTimeToBuyAndSellStockII
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] - prices[i - 1] > 0)        // difference between current and previous price is positive.
                {
                    maxProfit = maxProfit + prices[i] - prices[i - 1];        
                    // take positive difference and add to the running total.
                }
            }

            Console.WriteLine(maxProfit);
            return maxProfit;
        }
    }
}