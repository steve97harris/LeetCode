using System;

namespace LeetCode.Main
{
    public static class ValidPerfectSquare
    {
        public static bool IsPerfectSquare(int num)
        {
            double i = 1;

            var isFound = false;
            while (true)
            {
                if (i * i == num)
                {
                    isFound = true;
                    return true;
                }

                if (i * i > num)
                    break;

                i++;
            }

            return false;
        }
    }
}