using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public class MinCostTreeFromLeafValues
    {
        public int MctFromLeafValues(int[] arr)
        {
            var res = 0;
            
            var stack = new Stack<int>();
            stack.Push(int.MaxValue);

            for (int i = 0; i < arr.Length; i++)
            {
                while (stack.Peek() <= arr[i])
                {
                    var mid = stack.Pop();
                    res += mid * Math.Min(stack.Peek(), arr[i]);
                }
                stack.Push(arr[i]);
            }

            while (stack.Count > 2)
            {
                res += stack.Pop() * stack.Peek();
            }

            return res;
        }
    }
}