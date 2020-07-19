using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class PancakeFlipping
    {
        public IList<int> PancakeSort(int[] A)
        {
            var res = new List<int>();
            Pancake(A, A.Length - 1, res);

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
            return res;
        }

        private void Pancake(int[] arr, int currSize, List<int> list)
        {
            if (currSize <= 0)
                return;

            var maxNum = int.MinValue;
            var maxIndex = -1;
            for (int i = 0; i <= currSize; i++)
            {
                if (arr[i] > maxNum)
                {
                    maxNum = arr[i];
                    maxIndex = i;
                }
            }
            
            // var maxNum = arr.Take(currSize).Max();
            // var maxIndex = arr.ToList().IndexOf(maxNum);
            
            

            if (maxIndex > 0)
            {
                Array.Reverse(arr, 0, maxIndex + 1);
                list.Add(maxIndex + 1);
            }

            if (maxNum > 0)
            {
                Array.Reverse(arr, 0, currSize + 1);
                list.Add(currSize + 1);
            }

            // foreach (var i in arr)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("-----");

            Pancake(arr, currSize - 1, list);
        }
    }
}