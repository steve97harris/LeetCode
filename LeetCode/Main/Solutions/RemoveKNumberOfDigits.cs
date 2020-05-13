using System;

namespace LeetCode.Main
{
    public static class RemoveKNumberOfDigits
    {
        private static string smallestNum = "";
        public static string RemoveKdigits(string num, int k)
        {
            RemoveDigitsHelper(num, k);

            Console.WriteLine("smallestNum = " + smallestNum);
            return smallestNum;
        }

        private static void RemoveDigitsHelper(string num, int k)
        {
            if (k == 0)
            {
                smallestNum += num;
                return;
            }

            if (num.Length <= k)
                return;

            var minIndex = 0;
            for (int i = 1; i <= k; i++)
            {
                if (num[i] < num[minIndex])
                    minIndex = i;
            }

            smallestNum += num[minIndex];

            var newString = num.Substring(minIndex + 1);
            
            RemoveDigitsHelper(newString, k - minIndex);
        }
    }
}