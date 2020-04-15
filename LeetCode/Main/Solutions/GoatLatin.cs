using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class GoatLatin
    {
        public static string ToGoatLatin(string S)
        {
            var arrayS = S.Split(' ');
            var vowels = new[] {"a", "A", "e", "E", "i", "I", "o", "O", "u", "U"};
            var multipleAs = new List<string>();
            
            for (int i = 0; i < arrayS.Length; i++)
            {
                string temp = new string('a',i+1);
                multipleAs.Add(temp);
                
                if (StartsWithAny(arrayS[i],vowels)) 
                {
                    arrayS[i] = arrayS[i].Insert(arrayS[i].Length, "ma");
                }
                else if (!StartsWithAny(arrayS[i], vowels) || arrayS[i].Length <= 1)
                {
                    var firstLetter = arrayS[i][0];
                    arrayS[i] = arrayS[i].Remove(0, 1);
                    arrayS[i] = arrayS[i].Insert(arrayS[i].Length, firstLetter.ToString());
                    arrayS[i] = arrayS[i].Insert(arrayS[i].Length, "ma");
                }
                arrayS[i] = arrayS[i].Insert(arrayS[i].Length, multipleAs[i]);
                // Console.WriteLine(arrayS[i]);
            }

            S = string.Join(" ", arrayS);
            return S;
        }

        private static bool StartsWithAny(string s, string[] vowels)
        {
            return vowels.Any(s.StartsWith);
        }
    }
}