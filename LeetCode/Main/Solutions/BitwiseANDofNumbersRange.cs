using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class BitwiseANDofNumbersRange
    {
        public static int RangeBitwiseAnd(int m, int n)
        {
            // var qwertyNums = new List<int>();
            // for (int i = m; i <= n; i++)
            // {
            //     qwertyNums.Add(i);
            // }
            //
            // var qwerty = qwertyNums.Aggregate((previousList, nextList) => previousList & nextList);
            //
            // Console.WriteLine(qwerty);
            // return qwerty;

            var result = 0;

            while (m > 0 && n > 0)
            {
                var msbPositionM = MsbPosition(m);
                var msbPositionN = MsbPosition(n);

                if (msbPositionM != msbPositionN)
                    break;

                var msbValue = (1 << msbPositionM);
                result += msbValue;

                m -= msbValue;
                n -= msbValue;
            }

            return result;
        }

        private static int MsbPosition(int x)
        {
            var msbPos = -1;
            while (x > 0)
            {
                x >>= 1;        // Shifts left-hand operand right by the number of bits defined, e.g: shift right once while n > 0;
                msbPos++;
            }

            return msbPos;
        }
    }
}