using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class FindTheTownJudge
    {
        public static int FindJudge(int N, int[][] trust)
        {
            // trust[i] = [a, b] => a trusts b

            var townJudge = -1;

            switch (trust.Length)
            {
                case 1:
                    return trust[0][1];
                case 0:
                    return N;
            }

            var aList = new List<int>();
            var potentialTrusties = new List<int>();

            for (int i = 0; i < trust.Length; i++)
            {
                aList.Add(trust[i][0]);
            }

            for (int i = 0; i < trust.Length; i++)
            {
                if (!aList.Contains(trust[i][1]))
                {
                    townJudge = trust[i][1];
                    potentialTrusties.Add(trust[i][0]);
                }
            }

            for (int i = 1; i <= N; i++)
            {
                if (i != townJudge && !potentialTrusties.Contains(i))
                    townJudge = -1;
            }

            Console.WriteLine(townJudge);
            return townJudge;
        }
    }
}