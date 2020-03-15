using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class SortByParity
    {
        public static int[] SortArrayByParity(int[] A)
        {
            List<int> listEven = new List<int>();
            List<int> listOdd = new List<int>();

            foreach (int x in A)
            {
                if (x % 2 == 0)        // if number is even
                {
                    listEven.Add(x);
                }
                else             // if odd
                {
                    listOdd.Add(x);
                }
            }

            IEnumerable<int> listResult = listEven.Concat(listOdd);
            IEnumerable<int> enumerable = listResult as int[] ?? listResult.ToArray();
            A = enumerable.ToArray();

            foreach (int integer in A)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine(A);

            return A;
        }
        
        
    }
}