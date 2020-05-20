using System;
using System.Linq;
using System.Numerics;

namespace LeetCode.Main
{
    public static class StringToInteger
    {
        public static int MyAtoi(string str)
        {
            var indexOfLetter = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                    continue;
                
                indexOfLetter = i;
                break;
            }

            if (indexOfLetter != -1)
                str = str.Remove(indexOfLetter, str.Length - indexOfLetter);

            
            Console.WriteLine(str);
            
            double.TryParse(str, out var result);

            if (result >= 2147483647)
                return 2147483647;

            if (result < -2147483647)
                return -2147483648;
            
            Console.WriteLine("result = " + (int) result);

            return (int) result;
        }
    }
}