using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ReversingIntegerDigits
    {
        public static int ReverseInt(int x)
        {
            string xString = x.ToString();
            List<char> intList = new List<char>();

            foreach (char character in xString)
            {
                if (character == '-')
                {
                    intList.Remove(character);
                }
                else
                {
                    intList.Add(character);
                }
            }

            intList.Reverse();
            string intListAsString = string.Join("", intList.ToArray());

            
            if (x < 0)
            {
                x =  -Int32.Parse(intListAsString);
            }
            else
            {
                x = Int32.Parse(intListAsString);
            }

            Console.WriteLine(x);
            return x;
        }
    }
}