using System;
using LeetCode.Main.Solutions;

namespace LeetCode.Main
{
    namespace LeetCode.Main
    {
        public static class RunMe
        {
            static void Main()
            {
                int[][] x =
                    {
                        new [] { 1,1,0,0,0 }, 
                        new [] { 1,1,1,1,0 }, 
                        new [] { 1,0,0,0,0 }, 
                        new [] { 1,1,0,0,0 },
                        new [] { 1,1,1,1,1 }
                    };
                KWeakestRowsInMatrix.KWeakestRows(x, 3);
            }
        }
    }
}