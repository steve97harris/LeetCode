using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class FirstUniqueCharInString
    {
        public static int FirstUniqChar(string s)
        {
            var countDic = new Dictionary<char,int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!countDic.ContainsKey(s[i]))
                    countDic.Add(s[i],0);
                countDic[s[i]] += 1;
            }

            var uniquePair = countDic.Select(k => k).FirstOrDefault(x => x.Value == 1);

            Console.WriteLine(uniquePair.Key);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == uniquePair.Key)
                    return i;
            }

            return -1;
        }
    }
}