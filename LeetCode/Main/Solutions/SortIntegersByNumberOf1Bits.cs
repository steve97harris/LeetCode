using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class SortIntegersByNumberOf1Bits
    {
        public static int[] SortByBits(int[] arr)
        {
            List<int> result = new List<int>();
            Dictionary<int,int> arrayDictionary = new Dictionary<int, int>();
            List<int> valuesAsList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                arrayDictionary.Add(arr[i], CountBits(arr[i]));
            }

            foreach (var x in arrayDictionary)
            {
                valuesAsList.Add(x.Value);
                Console.WriteLine("[{0},{1}]", x.Key, x.Value);
            }

            IOrderedEnumerable<KeyValuePair<int, int>> sortedDic;
            if (valuesAsList.Distinct().Skip(1).Any())
            {
                sortedDic = arrayDictionary.OrderBy(x => x.Key);
            }
            else
            {
                sortedDic = arrayDictionary.OrderBy(x => x.Value);
            }
            
            foreach (KeyValuePair<int,int> xPair in sortedDic)
            {
                result.Add(xPair.Key);
            }

            arr = result.ToArray();

            return arr;
        }

        public static int CountBits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count += num & 1;
                num >>= 1;
            }

            return count;
        }
    }
}