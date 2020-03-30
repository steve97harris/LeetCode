using System;
using System.Linq;

namespace LeetCode.Main
{
    public static class FactorialTrailingZeros
    {
        public static int TrailingZeroes(int n)
        {
            int nFactorial = 1;

            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * (n - i);
                Console.WriteLine(nFactorial);
            }
            //Console.WriteLine("nFac = " + nFactorial);
            
            int trailingZeros = 0;

            string nFacString = nFactorial.ToString();

            for (int i = nFacString.Length - 1; i >= 0; i--)
            {
                if (nFacString[i] == '0')
                {
                    ++trailingZeros;
                }
                else
                {
                    break;
                }
            }

            // Console.WriteLine(trailingZeros);
            return trailingZeros;
        }
    }
}