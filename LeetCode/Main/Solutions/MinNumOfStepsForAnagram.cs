using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class MinNumOfStepsForAnagram
    {
        public static int MinSteps(string s, string t)
        {
            int minSteps = 0;

            Dictionary<char, int> sameChars = new Dictionary<char, int>();
            
            // {Key, Value} pair = {Key, Count}
            // Group by character, select new grouping: {Key, Count}
            var sCount = s.GroupBy(c => c).Select(g => new {g.Key, Count = g.Count()});
            var tCount = t.GroupBy(c => c).Select(g => new {g.Key, Count = g.Count()});
            
            Console.WriteLine("s: [key,count]");
            foreach (var sPair in sCount)
            {
                Console.WriteLine("[ {0} , {1} ]", sPair.Key, sPair.Count);

                foreach (var tPair in tCount)
                {
                    if (sPair.Key == tPair.Key)
                    {
                        sameChars.Add(sPair.Key, sPair.Count);
                    }
                }
            }


            int tSum = 0;
            Console.WriteLine("t: [key,count]");
            foreach (var tPair in tCount)
            {
                Console.WriteLine("[ {0} , {1} ]", tPair.Key, tPair.Count);
                tSum = tSum + tPair.Count;
            }

            
            Console.WriteLine("sameChars , sChar count: ");
            foreach (var c in sameChars)
            {
                Console.WriteLine("[ {0} , {1} ]", c.Key, c.Value);
            }

            minSteps = tSum - sameChars.Count;
            
            
            Console.WriteLine(minSteps);
            return minSteps;
        }
    }
}