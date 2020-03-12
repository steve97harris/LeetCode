using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class SumOfArrayEqualZero
    {
        public static int[] SumZero(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(-10, 10);
            }

            List<int> arrayList = new List<int>();
            foreach (int x in array)
            {
                if (!arrayList.Contains(x))
                {
                    arrayList.Add(x);
                }
                else
                {
                    int newNumber = new Random().Next(-10,10);
                    arrayList.Add(newNumber);
                }
            }

            int arraySum = arrayList.Sum();
            if (arraySum > 0 || arraySum < 0)
            {
                int zeroDifference = -arraySum;
                arrayList[0] += zeroDifference;
            }

            array = arrayList.ToArray();
                
            Console.WriteLine("Sum = " + array.Sum());

            return array;
        }
    }
}