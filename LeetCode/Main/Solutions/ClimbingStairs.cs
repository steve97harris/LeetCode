using System;

namespace LeetCode.Main.VersatileClasses
{
    public static class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            return Climb(0, n);
        }

        private static int Climb(int i, int n)
        {
            if (i > n)
                return 0;
            if (i == n)
                return 1;

            return Climb(i + 1, n) + Climb(i + 2, n);
        }
        
        // or

        private static int ClimbTheStairs(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            double fibn = Math.Pow((1+sqrt5)/2,n+1)-Math.Pow((1-sqrt5)/2,n+1);
            return (int)(fibn/sqrt5);   
        }
    }
}