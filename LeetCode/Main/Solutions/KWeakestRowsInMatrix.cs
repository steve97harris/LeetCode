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
            
            Dictionary<int,int> sortedSoldiers = new Dictionary<int, int>(soldierRows.OrderBy(x => x.Value));
            List<int> result = new List<int>(sortedSoldiers.Keys);
            int[] arrayResult = new int[k];
            for (int i = 0; i < k; i++)
            {
                arrayResult[i] = result[i];
            }

            foreach (int i in arrayResult)
            {
                Console.WriteLine(i);
            }
            
            return keys;
        }
    }
}