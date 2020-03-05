using System;

namespace LeetCode.Main.Solutions
{
    public class DecompressRunLengthEncodedList
    {
        public static int[] DecompressRLEList(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                (int freq, int val) = (nums[2 * i], nums[2 * i + 1]);

                int[] genArray = new int[freq];
                
                for (int j = 0; j < freq; j++)
                {
                    genArray[j] = val;
                }
                Console.WriteLine(genArray);
            }

            return nums;
        }
    }
}