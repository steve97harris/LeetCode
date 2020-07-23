using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class DisplayTableOfFoodOrdersInARestaurant
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            var tables = new SortedDictionary<int,List<string>>();
            var displayTable = new List<IList<string>>();
            var line01 = new List<string> {"Table"};

            var alphaSort = new List<string>();
            for (int i = 0; i < orders.Count; i++)
            {
                var tableNumber = orders[i][1];
                var foodItem = orders[i][2];
                int.TryParse(tableNumber, out var tableNo);

                if (!tables.ContainsKey(tableNo))
                    tables.Add(tableNo, new List<string>() { foodItem });
                else
                    tables[tableNo].Add(foodItem);
                
                if (!alphaSort.Contains(foodItem))
                    alphaSort.Add(foodItem);
            }
            alphaSort = alphaSort.OrderBy(x => x).ToList();
            line01.AddRange(alphaSort);
            displayTable.Add(line01);
            
            foreach (var pair in tables)
            {
                var tempList = line01.Select(s => "0").ToList();
                tempList[0] = pair.Key.ToString();
                foreach (var indexOfFoodItem in pair.Value.Select(s => line01.IndexOf(s)))
                {
                    int.TryParse(tempList[indexOfFoodItem], out var result);
                    result++;
                    tempList[indexOfFoodItem] = result.ToString();
                }
                displayTable.Add(tempList); 
            }

            foreach (var list in displayTable)
            {
                foreach (var s in list)
                {
                    Console.Write(s + ", ");
                }
                Console.WriteLine("");
                Console.WriteLine("------");
            }
            
            return displayTable;
        }
    }
}