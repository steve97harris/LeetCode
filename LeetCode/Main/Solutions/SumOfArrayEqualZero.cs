using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class SumOfArrayEqualZero
    {
        public static int[] SumZero(int n)
        {
            int[] newArray = GenerateNewArray(n);

            if (newArray.Sum() != 0)
            {
                newArray = GenerateNewArray(n);
            }
            else
            {
                foreach (int x in newArray)
                { 
                    Console.WriteLine(x);
                }
                Console.WriteLine("Sum = " + newArray.Sum());
            }
            return newArray;
        }

        private static int[] GenerateNewArray(int arrayLength)
        {
            int[] array = new int[arrayLength];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-10, 10);
            }

            return array;
        }
    }
}