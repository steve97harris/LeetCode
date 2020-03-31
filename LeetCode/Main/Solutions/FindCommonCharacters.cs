using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class FindCommonCharacters
    {
        public static IList<string> CommonChars(string[] A)
        {
            List<string> aList = new List<string>();
            IList<string> result = new List<string>();

            for (int i = 1; i < A.Length; i++)
            {
                aList.Add(A[i]);
            }

            foreach (var c in A[0])
            {
                result.Add(c.ToString());

                foreach (var word in aList)
                {
                    if (!word.Contains(c))
                    {
                        result.Remove(c.ToString());
                    }
                    else if (word.Contains(c) && word.IndexOf(c) != word.LastIndexOf(c))
                    {
                        result.Remove(c.ToString());
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