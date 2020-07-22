using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class BuildAnArrayWithStackOperations
    {
        public List<string> BuildArray(int[] target, int n)
        {
            var res = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i > target.Max())
                    break;
                
                if (target.Contains(i))
                    res.Add("Push");
                else
                {
                    res.Add("Push");
                    res.Add("Pop");
                }
            }

            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }

            return res;
        }
    }
}