using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class ShuffleAnArray
    {
        private List<int> originalNums;
        private int[] shuffledNums;
        public ShuffleAnArray(int[] nums)
        {
            originalNums = nums.ToList();
        }

        public int[] Reset()
        {
            Console.WriteLine("Reset: ");
            foreach (var i in originalNums)
            {
                Console.WriteLine(i);
            }
            return originalNums.ToArray();
        }

        public int[] Shuffle()
        {
            shuffledNums = originalNums.ToArray();
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