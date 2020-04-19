using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SortIntegersByPowerValue
    {
        public static int GetKthElement(int lo, int hi, int k)
        // Implies array of {lo,...,hi}.
        {
            var dictionary = new Dictionary<int,int>();
            var loToHi = new int[hi - lo + 1];

            for (int i = 0; i < (hi - lo) + 1; i++)
            {
                loToHi[i] = i + lo;
                var powerOfInt = PowerOfInt(loToHi[i]);
                dictionary.Add(loToHi[i],powerOfInt);
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0},{1}",pair.Key,pair.Value);
            }

            var orderedByVal = dictionary.OrderBy(x => x.Value);
            var orderedKeys = new List<int>();
            foreach (var pair in orderedByVal)
            {
                orderedKeys.Add(pair.Key);
            }

            var result = orderedKeys[k - 1];
            Console.WriteLine(result);
            return result;
        }

        private static int PowerOfInt(int x)
        {
            var list = new List<int>();
            while (x != 1)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                    list.Add(x);
                }
                else
                {
                    x = 3 * x + 1;
                    list.Add(x);
                }
            }
            
            return list.Count;
        }
    }
}