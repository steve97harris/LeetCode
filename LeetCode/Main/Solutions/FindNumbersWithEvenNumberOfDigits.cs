using System;

namespace LeetCode.Main.Solutions
{
    public static class FindNumbersWithEvenNumberOfDigits
    {
        public static int FindNumbers(int[] nums)
        {
            int evenDigits = 0;

            string[] numString = new string[nums.Length];
            int[] digitsPerElement = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
            {
                numString[i] = nums[i].ToString();
                digitsPerElement[i] = numString[i].Length;
                if (digitsPerElement[i] % 2 == 0)
                {
                    ++evenDigits;
                }
            }

            Console.WriteLine(evenDigits);

            return evenDigits;
        }
    }
}