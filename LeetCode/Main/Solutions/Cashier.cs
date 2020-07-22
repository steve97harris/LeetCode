using System.Collections.Generic;

namespace LeetCode.Main
{
    public class Cashier
    {
        private int customer = 0;
        private int _n;
        private int _discount;
        private Dictionary<int, int> productPrices = new Dictionary<int, int>();
        
        public Cashier(int n, int discount, int[] products, int[] prices)
        {
            _n = n;
            _discount = discount;

            for (int i = 0; i < products.Length; i++)
            {
                productPrices.Add(products[i], prices[i]);
            }
        }

        public double GetBill(int[] product, int[] amount)
        {
            var bill = 0.0f;
            
            for (int i = 0; i < product.Length; i++)
            {
                for (int j = 0; j < amount[i]; j++)
                {
                    bill += productPrices[product[i]];
                }
            }

            customer++;

            if (customer != _n) 
                return bill;
            
            bill -= (_discount * bill) / 100;
            customer = 0;

            return bill;
        }
    }
}