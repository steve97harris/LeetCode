using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ElementAppearingMoreThan25InSortedArray
    {
        public static int FindSpecialInteger(int[] arr)
        {
            var numberFreq = new Dictionary<int,int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (numberFreq.ContainsKey(arr[i]))
                    numberFreq[arr[i]] += 1;
                else
                    numberFreq.Add(arr[i],1);
            }

            var quarterOfArr =  0.25 * arr.Length;
            return (from pair in numberFreq where pair.Value > quarterOfArr select pair.Key).FirstOrDefault();
        }
    }
}