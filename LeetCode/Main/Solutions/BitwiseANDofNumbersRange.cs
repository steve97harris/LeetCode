using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class BitwiseANDofNumbersRange
    {
        public static int RangeBitwiseAnd(int m, int n)
        {
            var qwertyNums = new List<int>();
            for (int i = m; i <= n; i++)
            {
                qwertyNums.Add(i);
            }

            var qwerty = qwertyNums.Aggregate((previousList, nextList) => previousList & nextList);
            
            Console.WriteLine(qwerty);
            return qwerty;
        }
    }
}