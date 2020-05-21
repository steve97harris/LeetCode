using System;
using System.Linq;

namespace LeetCode
{
    public class FindingLongestCommonPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            
            var prefixArr = strs.First()
                .Substring(0, strs.Min(s => s.Length))
                .TakeWhile((c, i) => strs.All(s => s[i] == c)).ToArray();

            if (prefixArr.Length == 0)
                return "";

            Console.WriteLine(new string(prefixArr));
            return new string(prefixArr);
        }
    }
}