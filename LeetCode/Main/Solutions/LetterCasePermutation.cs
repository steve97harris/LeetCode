using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class LetterCasePermutation
    {
        public static IList<string> CasePermutation(string S)
        {
            var result = new List<string>();

            char[] array = S.ToLower().ToCharArray();
            int iterations = (1 << array.Length) - 1;

            for (int i = 0; i <= iterations; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if ((i & (1 << j)) != 0)
                        array[j] = char.ToUpper(array[j]);
                    else
                        array[j] = char.ToLower(array[j]);
                }
                if (!result.Contains(new string(array)))
                    result.Add(new string(array));
            }
            
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
            return result;
        }
    }
}