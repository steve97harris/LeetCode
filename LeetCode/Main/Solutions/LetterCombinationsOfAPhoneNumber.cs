using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class LetterCombinationsOfAPhoneNumber
    {
        private static IList<string> list = new List<string>();
        public static IList<string> LetterCombinations(string digits)
        {
            var x = "abc";
            var y = "def";
            var z = "ghi";

            CombinationOfTwoStrings(x,y);
            
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            return list;
        }

        private static void CombinationOfTwoStrings(string a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    var temp = "";
                    temp += a[i].ToString() + b[j].ToString();
                    
                    if (!list.Contains(temp))
                        list.Add(temp);
                }
            }
        }
    }
}