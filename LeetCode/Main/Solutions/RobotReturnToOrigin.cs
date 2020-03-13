using System;

namespace LeetCode.Main.Solutions
{
    public static class RobotReturnToOrigin
    {
        public static bool JudgeCircle(string moves)
        {
            bool robotAtOrigin = true;
            
            int right = 0;
            int left = 0;
            int up = 0;
            int down = 0;

            int rightLeftDifference;
            int upDownDifference;
            
            foreach (char character in moves)
            {
                if (character == 'R')
                {
                    ++right;
                }
                else if (character == 'L')
                {
                    ++left;
                }
                else if (character == 'U')
                {
                    ++up;
                }
                else if (character == 'D')
                {
                    ++down;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }

            rightLeftDifference = right - left;
            upDownDifference = up - down;

            if (rightLeftDifference != 0 || upDownDifference != 0)
            {
                robotAtOrigin = false;
            }

            Console.WriteLine("Robot at Origin: " + robotAtOrigin);
            return robotAtOrigin;
        }
    }
}