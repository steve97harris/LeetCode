using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ComplementOfBase10Integer
    {
        public static int BitwiseComplement(int N)
        {
            var nBase2 = Convert.ToString(N, 2).ToArray();
            for (int i = 0; i < nBase2.Length; i++)
            {
                if (nBase2[i] == '1')
                    nBase2[i] = '0';
                else
                    nBase2[i] = '1';
            }
            
            N = Convert.ToInt32(new string(nBase2), 2);
            
            return N;
        }
    }
}