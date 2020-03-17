using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class Max69Number
    {
        public static int Maximum69Number(int num)
        {
            List<int> intList = new List<int>();
            string numString = num.ToString();

            for (int i = 0; i < numString.Length; i++)
            {
                
                if (numString[i] == '9')
                {
                    numString.Remove(i);
                    numString.Insert(i, "6");
                }
                else // if == 6
                {
                    numString.Remove(i);
                    numString.Insert(i, "9");
                }
                intList.Add(Int32.Parse(numString));
                Console.WriteLine(intList[i]);
            }
            
            
            return num;
        }
    }
}