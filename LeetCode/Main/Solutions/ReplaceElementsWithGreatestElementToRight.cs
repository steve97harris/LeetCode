using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ReplaceElementsWithGreatestElementToRight
    {
        public static int[] ReplaceElements(int[] array)
        {
            List<int> maxList = new List<int>();
            

            for (int i = 0; i < array.Length; i++)
            {
                IEnumerable<int> skipRight = array.Skip(i).Take(array.Length);
                
                int max = skipRight.Max();
                maxList.Add(max);
            }

            foreach (int i in maxList)
            {
                Console.WriteLine(i);
            }


            return array;
        }
    }
}