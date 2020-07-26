using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public class CircularPermutationInBinaryRepresentation
    {
        public IList<int> CircularPermutation(int n, int start)
        {
            var listo = new List<int> {start};

            var binaryStart = Convert.ToString(start, 2);

            // while (listo.Count < Math.Pow(2,n) - 1)
            // {
            //     
            // }

            var grayArray = GenerateGrayArray(n);
            foreach (var s in grayArray)
            {
                Console.WriteLine(s);
            }

            return listo;
        }
        
        private List<string> GenerateGrayArray(int n) 
        { 
            // base case   
            if (n <= 0) 
            { 
                return new List<string>(); 
            } 
  
            // 'arr' will store all generated codes   
            var arr = new List<string> {"0", "1"};

            // Every iteration of this loop generates 2*i codes from previously   
            // generated i codes.   
            int i, j; 
            for (i = 2; i < (1 << n); i = i << 1) 
            { 
                // Enter the prviously generated codes again in arr[] in reverse   
                // order. Nor arr[] has double number of codes.   
                for (j = i - 1 ; j >= 0 ; j--) 
                { 
                    arr.Add(arr[j]); 
                } 
  
                // append 0 to the first half   
                for (j = 0 ; j < i ; j++) 
                { 
                    arr[j] = "0" + arr[j]; 
                } 
  
                // append 1 to the second half   
                for (j = i ; j < 2 * i ; j++) 
                { 
                    arr[j] = "1" + arr[j]; 
                } 
            }

            return arr;
        } 
    }
}