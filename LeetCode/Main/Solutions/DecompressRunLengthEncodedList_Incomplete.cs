using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public class DecompressRunLengthEncodedListIncomplete
    {
        public static int[] DecompressRLEList(int[] nums)
        {
            List<int> freqList = new List<int>();
            List<int> valList = new List<int>();
            
            List<int> result = new List<int>();
            
            if (nums.Length > 2)
            {
                for (int i = 0; i < (nums.Length - 1) / 2; i++)
                {
                    int freq = nums[2 * i];
                    freqList.Add(freq);
                    int val = nums[2 * i + 1];
                    valList.Add(val);
                }
            }
            else if (nums.Length <= 2) 
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    int freq = nums[2 * i];
                    freqList.Add(freq);
                    int val = nums[2 * i + 1];
                    valList.Add(val);
                }   
            }

            for (int i = 0; i < freqList.Count; i++)
            {
                int[] newArray = new int[freqList[i]];
                for (int j = 0; j < newArray.Length; j++)
                {
                    newArray[j] = valList[i];
                    // Console.WriteLine("newArray[j] = " + newArray[j]);
                    result.Add(newArray[j]);
                }
            }

            nums = result.ToArray();
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            return nums;
        }
    }
}