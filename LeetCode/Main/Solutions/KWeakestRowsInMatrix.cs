using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class KWeakestRowsInMatrix
    {
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            int[] keys = new int[mat.Length + 1];
            Dictionary<int,int> soldierRows = new Dictionary<int, int>();
            keys[0] = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                keys[i + 1] = keys[i] + 1;
                soldierRows.Add(keys[i], mat[i].Sum());
            }

            foreach (KeyValuePair<int,int> xPair in soldierRows)
            {
                Console.WriteLine("{0},{1}", xPair.Key,xPair.Value);
            }
            
            return keys;
        }
    }
}