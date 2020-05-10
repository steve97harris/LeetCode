using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class PartitionDeLabels
    {
        public static IList<int> PartitionLabels(string S)
        {
            var list = new List<int>();
            
            var dic = new Dictionary<char, int[]>();
            var distinctS = S.Distinct().ToArray();
            for (int i = 0; i < distinctS.Length; i++)
            {
                var firstAndLast = new int[2];
                firstAndLast[0] = S.IndexOf(distinctS[i]);
                firstAndLast[1] = S.LastIndexOf(distinctS[i]);
                dic.Add(distinctS[i],firstAndLast);
            }

            var y = new List<string>();
            
            var lastArr = dic[S[0]];
            var lastString = S[0].ToString();
            foreach (var pair in dic)
            {
                Console.WriteLine("----");
                Console.WriteLine(pair.Key);
                var x = pair.Value;
                Console.WriteLine(x[0] + ", " + x[1]);
                
                if (x[0] > lastArr[0] && x[0] < lastArr[1] || x[0] == x[1])
                    lastString += pair.Key;
                if (x[0] > lastArr[1])
                {
                    y.Add(lastString);
                    lastArr = pair.Value;
                    lastString = pair.Key.ToString();
                }
            }

            foreach (var s in y)
            {
                Console.WriteLine(s);
            }

            return list;
        }
    }
}