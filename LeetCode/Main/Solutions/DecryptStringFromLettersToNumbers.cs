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
            string numbers = "0123456789";
            string[] numbers2 = {"10#","11#","12#","13#","14#","15#","16#","17#","18#","19#","20#","21#","22#","23#","24#","25#","26#"};
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            
            var dictionary = new Dictionary<string, char>();

            for (int i = 0; i < numbers.Length; i++)
            {
                dictionary.Add(numbers[i].ToString(),alphabet[i]);
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                dictionary.Add(numbers2[i], alphabet[i + numbers.Length -1]);
            }

            foreach (var x in dictionary)
            {
                Console.WriteLine(x);
            }
            
            var hashPositions = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    hashPositions.Add(i);
                }
            }

            var sToList = new List<string>();
            for (int i = 0; i < hashPositions.Count; i++)
            {
                var hashNumber = s.Substring(hashPositions[i] - 2, 3);
                sToList.Add(hashNumber);
            }

            for (int i = 0; i < hashPositions.Count; i++)
            {
                s = s.Remove(hashPositions[i] - 2, 3);
            }

            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    sToList.Add(s[i].ToString());
                }
            }

            s = "";
            for (int i = 0; i < sToList.Count; i++)
            {
                dictionary.TryGetValue(sToList[i], out var hashValue);
                s += hashValue;
            }
            
            Console.WriteLine(s);
            return s;
        }
    }
}