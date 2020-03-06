using System;

namespace LeetCode.Main.Solutions
{
    public class DecompressRunLengthEncodedListIncomplete
    {
        public static int[] DecompressRLEList(int[] nums)
        {
            for (int i = 0; i < (nums.Length + 1) / 2; i++)
            {
                int freq = nums[2 * i];
                int val = nums[2 * i + 1];
                Console.WriteLine("Freq = " + freq);
                
                int[] array = new int[freq];
                
                for (int j = 0; j < freq; j++)
                {
                    array[j] = val;
                    Console.WriteLine("Value = " + array[j]);
                    nums[i] = array[j];
                }
            }

            foreach (var x in nums)
            {
                Console.WriteLine(x);
            }

            return nums;
        }
    }
}