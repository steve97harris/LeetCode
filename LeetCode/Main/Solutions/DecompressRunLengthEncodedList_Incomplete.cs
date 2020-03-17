using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public class DecompressRunLengthEncodedListIncomplete
    {
        public static int[] DecompressRLEList(int[] nums)
        {
            List<int> outputList = new List<int>();

            List<int> freqList = new List<int>();
            List<int> valList = new List<int>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int freq = nums[2 * i];
                freqList.Add(freq);
                int val = nums[2 * i + 1];
                valList.Add(val);
            }

            for (int i = 0; i < freqList.Count; i++)
            {
                int[] newArray = new int[freqList[i]];
                
            }
            
            foreach (int ints in outputList)
            {
                Console.WriteLine(ints);
            }
            
            return nums;
        }
    }
}