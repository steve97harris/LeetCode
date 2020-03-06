using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ReplaceElementsWithGreatestElementToRight
    {
        public static int[] ReplaceElements(int[] array)
        {
            int lastElement = array.Length - 1;
            array[lastElement] = -1;

            for (int i = 0; i < lastElement; i++)
            {   
                if (array[i + 1] > array[i])
                {
                    array[i] = array[i + 1];
                }    
            }

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
            return array;
        }
    }
}