using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class DailyTemperatures
    {
        public static int[] DailyTemps(int[] T)
        {
            // int daysUntilWarmer = 0;
            List<int> tList = new List<int>();
            List<int> output = new List<int>();

            foreach (int i in T)
            {
                tList.Add(i);
            }
            
            // for (int i = 0; i < T.Length - 1; i++)
            // {
            //     if (T[i] < T[i + 1])
            //     {
            //         daysUntilWarmer =1;
            //         output.Add(daysUntilWarmer);
            //     }
            //
            //     while (T[i] >= T[i+1])
            //     {
            //         ++daysUntilWarmer;
            //         output.Add(daysUntilWarmer);
            //     }
            // }

            Console.WriteLine("T List: ");
            foreach (int x in tList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Output List: ");
            foreach (int integer in output)
            {
                Console.WriteLine(integer);
            }
            
            int[] result = output.ToArray();
            return result;
        }
    }
}