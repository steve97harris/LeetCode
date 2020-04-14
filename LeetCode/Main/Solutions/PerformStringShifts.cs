using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class PerformStringShifts
    {
        // shift = [direction, amount]
        public static string StringShift(string s, int[][] shift)
        {
            var listS = new List<char>();
            foreach (var c in s)
            {
                listS.Add(c);
            }

            for (int i = 0; i < shift.Length; i++)
            {
                switch (shift[i][0])
                {
                    case 0:
                    {
                        for (int j = 0; j < shift[i][1]; j++)
                        {  
                            Console.WriteLine("left");
                            var temp = listS[0];
                            listS.RemoveAt(0);
                            listS.Add(temp);
                        }
                        break;
                    }
                    case 1:
                        for (int j = 0; j < shift[i][1]; j++)
                        {  
                            Console.WriteLine("right");
                            var temp = listS[^1];
                            listS.RemoveAt(listS.Count - 1);
                            listS.Insert(0,temp);
                        }
                        break;
                }
            }

            var result = new string(listS.ToArray());
            return result;
        }
    }
}