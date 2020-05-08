using System;

namespace LeetCode.Main
{
    public static class CheckIfItIsAStraightLine
    {
        public static bool CheckStraightLine(int[][] coordinates)
        {
            // y = mx + c , m is gradient, c is y intercept;
            
            var m = 0;
            var diff1 = coordinates[1][0] - coordinates[0][0];
            var diff2 = coordinates[1][1] - coordinates[0][1];
            if (diff1 == 0 || diff2 == 0)
                m = 0;
            else
                m = diff2 / diff1;
            Console.WriteLine(m);

            var c = coordinates[0][1] - m * coordinates[0][0];
            Console.WriteLine(c);
            
            if (coordinates.Length <= 1)
                return false;

            for (int i = 0; i < coordinates.Length; i++)
            {
                var x = coordinates[i][0];
                var y = coordinates[i][1];

                if (m * x + c == y) continue;
                Console.WriteLine(x + ", " + y);
                Console.WriteLine("f");
                return false;
            }

            return true;
        }
    }
}