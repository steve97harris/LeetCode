using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Solutions
{
    public static class DecryptStringFromLettersToNumbers
    {
        public static string FreqAlphabets(string s)
        {
            var numbers = new string[] {"1","2","3","4","5","6","7","8","9","10#","11#","12#","13#","14#","15#","16#","17#","18#","19#","20#","21#","22#","23#","24#","25#","26#"};
            const string alphabet = "abcdefghijklmnopqrstuvwxyz";
            
            var map = new Dictionary<string, char>();
            for (int i = 0; i < numbers.Length; i++)
            {
                map.Add(numbers[i], alphabet[i]);
            }

            var res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 2 && s[i + 2] == '#')
                {
                    var hashNum = s.Substring(i, 3);
                    map.TryGetValue(hashNum, out var mapLetter);
                    res += mapLetter;
                    i += 2;
                }
                else
                {
                    map.TryGetValue(s[i].ToString(), out var mapLetter);
                    res += mapLetter;
                }
            }
            
            Console.WriteLine(res);
            return res;
        }
    }
}