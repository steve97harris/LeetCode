using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class BinaryGapSol
    {
        public static int BinaryGap(int N)
        {
            var binaryN = Convert.ToString(N, 2);
            
            var indexOfOnes = new List<int>();
            for (int i = 0; i < binaryN.Length; i++)
            {
                if (binaryN[i] == '1')
                    indexOfOnes.Add(i);
            }

            var distanceBetweenOnes = new List<int>();
            for (int i = 0; i < indexOfOnes.Count-1; i++)
            {
                var x = indexOfOnes[i + 1] - indexOfOnes[i];
                distanceBetweenOnes.Add(x);
            }

            return distanceBetweenOnes.Count > 0 ? distanceBetweenOnes.Max() : 0;
        }
    }
}