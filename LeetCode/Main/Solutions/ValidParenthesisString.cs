using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class ValidParenthesisString
    {
        public static bool CheckValidString(string s)
        {
            if (s == null)
                return true;

            var leftCount = 0;
            var rightCount = 0;
            var specialCount = 0;
            var leftIndex = 0;
            var rightIndex = 0;
            var list = new List<int[]>();
            
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        ++leftCount;
                        leftIndex = i;
                        break;
                    case ')':
                        ++rightCount;
                        rightIndex = i;
                        break;
                    case '*':
                        ++specialCount;
                        break;
                }

                var x = new []{leftIndex, rightIndex};
                list.Add(x);
            }

            foreach (var array in list)
            {
                if (array[1] < array[0])
                {
                    Console.WriteLine("false*");
                    return false;
                }
            }

            for (int i = 0; i < specialCount; i++)
            {
                if (leftCount < rightCount)
                    leftCount += 1;
                else if (rightCount < leftCount)
                    rightCount += 1;
                else
                {
                    Console.WriteLine("true");
                    return true;
                }
            }

            Console.WriteLine("Left: " + leftCount);
            Console.WriteLine("Right: " + rightCount);
            Console.WriteLine(rightCount == leftCount ? "true" : "false");

            return rightCount == leftCount;
        }
    }
}