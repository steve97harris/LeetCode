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

            //
            // for (int i = 0; i < numString.Length; i++)
            // {
            //     for (int j = 0; j < 1; j++)
            //     {
            //         if (numString[j] == '9') 
            //         {
            //             numString = numString.Replace(numString[j], '6');
            //             intList.Add(Int32.Parse(numString));
            //         }
            //         else
            //         {
            //             numString = numString.Replace(numString[j], '9');
            //             intList.Add(Int32.Parse(numString));
            //         }
            //     }
            // }

            

            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }
            
            return num;
        }
    }
}