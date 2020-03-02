using System;

namespace LeetCode.Main.Solutions
{
    public class CountTheNegatives
    {
        public static int CountNegatives(int[][] grid)
        {
            int numberOfNegs = 0;
            
            foreach (int[] integerArray in grid)
            {
                foreach (int integer in integerArray)
                {
                    if (integer < 0)
                    {
                        ++numberOfNegs;
                    }
                }   
            }
            
            Console.WriteLine(numberOfNegs);
            return numberOfNegs;
        }
    }
}