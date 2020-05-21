using System;
using System.Linq;
using System.Numerics;

namespace LeetCode.Main
{
    public static class StringToInteger
    {
        public static int MyAtoi(string str)
        {
            var index = 0;
            var sign = 1;
            var total = 0;

            // remove spaces
            while (index < str.Length && str[index] == ' ')
            {
                index++;
            }

            // get sign '+' or '-'
            if (index < str.Length && (str[index] == '+' || str[index] == '-'))
                if (str[index++] == '+')
                    sign = 1;
                else
                    sign = -1;
            else
                sign = 1;

            // calculate and take care of overflow
            while (index < str.Length)
            {
                var digit = str[index++] - '0';
                if (digit < 0 || 9 < digit)
                    break;

                if (int.MaxValue / 10 < total || int.MaxValue / 10 == total && int.MaxValue % 10 < digit)
                    return sign == -1 ? int.MinValue : int.MaxValue;
                total = total * 10 + digit;
            }

            return total * sign;

            // var indexOfLetter = -1;
            // for (int i = 0; i < str.Length; i++)
            // {
            //     if (!char.IsLetter(str[i]))
            //         continue;
            //     
            //     indexOfLetter = i;
            //     break;
            // }
            //
            // if (indexOfLetter != -1)
            //     str = str.Remove(indexOfLetter, str.Length - indexOfLetter);
            //
            //
            // Console.WriteLine(str);
            //
            // double.TryParse(str, out var result);
            //
            // if (result >= 2147483647)
            //     return 2147483647;
            //
            // if (result < -2147483647)
            //     return -2147483648;
            //
            // Console.WriteLine("result = " + (int) result);
            //
            // return (int) result;
        }
    }
}