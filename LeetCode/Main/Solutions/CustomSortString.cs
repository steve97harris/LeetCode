using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class CustomSortStringI
    {
        public string CustomSortString(string S, string T)
        {
            var res = new char[T.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = 'X';
            }
            
            for (int i = 0; i < T.Length; i++)
            {
                if (S.Contains(T[i]))
                {
                    if (res.Contains(T[i]))
                    {
                        // shift chars right, then insert duplicate 
                        var x = res[^1];
                        for (int j = res.Length - 1; j > S.IndexOf(T[i]) + 1; j--)
                        {
                            res[j] = res[j - 1];
                        }
                        res[S.IndexOf(T[i]) + 1] = x;
                        
                        res[S.IndexOf(T[i]) + 1] = T[i];
                    }
                    else
                        res[S.IndexOf(T[i])] = T[i];
                }
            }

            for (int i = 0; i < T.Length; i++)
            {
                if (S.Contains(T[i])) 
                    continue;
                
                var xIndex = res.ToList().IndexOf('X');
                res[xIndex] = T[i];
            }

            var output = new string(res);
            Console.WriteLine(output);
            return output;
        }
    }
}