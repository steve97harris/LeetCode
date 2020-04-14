using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class UncommonWordsInSentences
    {
        
        public static string[] UncommonWords(string A, string B)
        {
            var notTheSame = new List<string>();
            var tempList = new List<string>();
            var splitA = A.Split(' ');
            var splitB = B.Split(' ');

            foreach (var s in splitA)
            {
                if (!splitB.Contains(s))
                {
                    if (notTheSame.Contains(s))
                    {
                        notTheSame.Remove(s);
                        tempList.Add(s);
                    }
                    else
                        notTheSame.Add(s);
                }
            }
            
            foreach (var s in splitB)
            {
                if (!splitA.Contains(s))
                {
                    if (notTheSame.Contains(s))
                    {
                        notTheSame.Remove(s);
                        tempList.Add(s);
                    }
                    else
                        notTheSame.Add(s);
                }
            }

            for (int i = 0; i < notTheSame.Count; i++)
            {
                for (int j = 0; j < tempList.Count; j++)
                {
                    if (tempList[j] == notTheSame[i])
                        notTheSame.Remove(notTheSame[i]);
                }
            }
            
            foreach (var s in notTheSame)
            {
                Console.WriteLine(s);
            }
            return notTheSame.ToArray();
        }
    }
}