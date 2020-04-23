using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class QueriesOnAPermutationWithKey
    {
        public static int[] ProcessQueries(int[] queries, int m)
        {
            var p = new List<int>();
            for (int i = 0; i < m; i++)
            {
                p.Add(i+1);
            }
            
            // var pDic = p.Select((val, ind) => new {Value = val, Index = ind}).ToDictionary(val => val.Value, ind => ind.Index);

            var list = new List<int>();

            foreach (var query in queries)
            {
                var indexOfQuery = p.IndexOf(query);
                list.Add(indexOfQuery);
                
                p = p.Prepend(query).ToList();
                p.RemoveAt(indexOfQuery + 1);
            }

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            
            return list.ToArray();
        }
    }
}