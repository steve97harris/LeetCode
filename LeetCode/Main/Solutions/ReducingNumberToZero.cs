﻿using System;
using System.Collections;

namespace LeetCode
{
    public static class ReducingNumberToZero
    { 
        public static int NumberOfSteps(int number)
        {
            int steps = 0;
            
            while (number > 0)
            {
                if (!IsOdd(number))
                {
                    number = number / 2;
                    // Console.WriteLine(number);
                    ++steps;
                }
                else if (IsOdd(number))
                {
                    number -= 1;
                    // Console.WriteLine(number);
                    ++steps;
                }
                // Console.WriteLine(steps);
            }
            Console.WriteLine(steps);
            return steps;
            // return number;
        }

        private static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}