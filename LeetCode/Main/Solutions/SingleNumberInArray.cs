using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class SingleNumberInArray
    {
        public static int SingleNumber(int[] nums)
        {
            int singleNumber = 0;
            List<int> numsList = new List<int>();
            List<int> duplicates = new List<int>();
            foreach (int num in nums)
            {
                if (!numsList.Contains(num))
                {
                    numsList.Add(num);
                }
                else
                {
                    duplicates.Add(num);
                }
            }

            for (int i = 0; i < numsList.Count; i++)
            {
                if (!duplicates.Contains(numsList[i]))
                {
                    singleNumber = numsList[i];
                }
            }
            
            Console.WriteLine(singleNumber);
            return singleNumber;
        }
    }
}