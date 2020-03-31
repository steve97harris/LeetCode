using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class FindCommonCharacters
    {
        public static IList<string> CommonChars(string[] A)
        {
            IList<string> result = new List<string>();
            
            foreach (var word in A)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (word.Contains(word[j]))
                    {
                        result.Add(word[j].ToString());
                    }
                }
            }

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            return result;
        }
    }
}