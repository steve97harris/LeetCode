using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class GroupAnagrams
    {
        public static IList<IList<string>> GroupTheAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();

            var map = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var sortedStr = String.Concat(str.OrderBy(x => x));
                if (map.ContainsKey(sortedStr))
                {
                    map[sortedStr].Add(str);
                }
                else
                {
                    map.Add(sortedStr, new List<string>{ str });
                }
            }

            foreach (var pair in map)
            {
                result.Add(pair.Value);
            }

            foreach (var group in result)
            {
                Console.WriteLine("---");
                foreach (var str in group)
                {
                    Console.WriteLine(str);
                }
            }
            
            return result;
        }
    }
}