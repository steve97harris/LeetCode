using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public class StockSpanner
    {
        private Stack<StockNode> stockPrice = new Stack<StockNode>();
        private int index;

        public StockSpanner()
        {
            
        }

        public int Next(int price)
        {
            while (stockPrice.Count != 0 && stockPrice.Peek().val <= price)
            {
                stockPrice.Pop();
            }

            var max = 0;
            if (stockPrice.Count != 0)
                max = stockPrice.Peek().itemIndex;
            else
                max = -1;
            
            stockPrice.Push(new StockNode(index, price));

            var result = index - max;
            index++;

            Console.WriteLine(result);
            return result;
        }
    }

    public class StockNode
    {
        public int itemIndex;
        public int val;

        public StockNode(int index, int val)
        {
            this.itemIndex = index;
            this.val = val;
        }
    }
}