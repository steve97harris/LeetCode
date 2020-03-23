using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ReverseWordsInStringIII
    {
        public static string ReverseWords(string s)
        {
            List<string> listOfWords = new List<string>();
            List<string> reverseList = new List<string>();
            listOfWords = s.Split(' ').ToList();

            foreach (string xWord in listOfWords)
            {
                char[] chars = xWord.ToCharArray();
                Array.Reverse(chars);
                reverseList.Add(new string(chars));
            }

            s = String.Join(" ", reverseList);

            Console.WriteLine(s);
            return s;
        }
    }
}