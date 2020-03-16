using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class SquaresOfSortedArray
    {
        public static int[] SortedSquares(int[] inputArray)
        {
            int[] xSquare = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                xSquare[i] = inputArray[i]*inputArray[i];
            }
            
            Array.Sort(xSquare);
            foreach (int x in xSquare)
            {
                Console.WriteLine(x);
            }
            return xSquare;
        }
    }
}