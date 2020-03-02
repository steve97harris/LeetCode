using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class ProductAndSum
    {
        public static int SubtractProductAndSum(int n)
        {
            int[] x = IntegerArray(n);

            int sum = x.Sum();

            int product = 1;
            foreach (int digit in x)
            {
                product *= digit;
            }
            
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Product = " + product);

            n = product - sum;
            Console.WriteLine("Product - Sum = " + n);
            return n;
        }

        public static int[] IntegerArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }

            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}