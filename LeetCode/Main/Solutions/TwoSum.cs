using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class TwoSum
    {
        public static int[] TwoSumm(int[] numbers, int target)
        {
            var result = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] != target || i == j) 
                        continue;
                    result[0] = i;
                    result[1] = j;
                    Console.WriteLine(i + ", " + j);
                }
            }

            return result;
        }
    }
}