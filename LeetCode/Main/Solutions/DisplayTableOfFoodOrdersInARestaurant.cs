using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class DisplayTableOfFoodOrdersInARestaurant
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            var customerName = "";
            var tableNumber = "";
            var foodItem = "";
            
            var tables = new Dictionary<string,List<string>>();
            
            for (int i = 0; i < orders.Count; i++)
            {
                customerName = orders[i][0];
                tableNumber = orders[i][1];
                foodItem = orders[i][2];

                if (!tables.ContainsKey(tableNumber))
                    tables.Add(tableNumber, new List<string>() { foodItem });
                else
                    tables[tableNumber].Add(foodItem);
            }

            
            return new List<IList<string>>();
        }
    }
}