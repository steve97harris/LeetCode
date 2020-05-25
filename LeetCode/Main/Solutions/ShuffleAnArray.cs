using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class ShuffleAnArray
    {
        private int[] originalNums;
        private int[] shuffledNums;
        public ShuffleAnArray(int[] nums)
        {
            originalNums = nums;
        }

        public int[] Reset()
        {
            Console.WriteLine("Reset: ");
            for (int i = 0; i < originalNums.Length; i++)
            {
                Console.WriteLine(originalNums[i]);
            }
            
            return originalNums;
        }

        public int[] Shuffle()
        {
            shuffledNums = originalNums;
            var random = new Random();
            var n = shuffledNums.Length;

            while (n > 1)
            {
                n--;
                var randomIndex = random.Next(n + 1);
                var val = shuffledNums[randomIndex];
                shuffledNums[randomIndex] = shuffledNums[n];
                shuffledNums[n] = val;
            }

            Console.WriteLine("Shuffle: ");
            foreach (var i in shuffledNums)
            {
                Console.WriteLine(i);
            }
            return shuffledNums;
        }
    }
}