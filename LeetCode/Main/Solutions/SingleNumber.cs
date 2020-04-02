using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class SingleNumber
    {
        public static int SingleNumberr(int[] nums)
        {
            int singleNum = 0;
            Dictionary<string,int> numAndCount = new Dictionary<string, int>();

            foreach (var i in nums)
            {
                if (!numAndCount.ContainsKey(i.ToString()))
                {
                    numAndCount.Add(i.ToString(),1);
                }
                else
                {
                    numAndCount[i.ToString()] = 2;
                }
            }

            foreach (var pair in numAndCount)
            {
                Console.WriteLine("{0},{1}", pair.Key,pair.Value);
                if (pair.Value == 1)
                {
                    singleNum = Int32.Parse(pair.Key);
                }
            }

            Console.WriteLine(singleNum);
            return singleNum;
        }
    }
}