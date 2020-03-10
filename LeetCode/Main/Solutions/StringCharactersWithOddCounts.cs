using System;
using System.Text;

namespace LeetCode.Main.Solutions
{
    public static class StringCharactersWithOddCounts
    {
        public static string GenerateTheString(int n)
        {
            string newWord = new string('x', n);
            StringBuilder newWord2 = new StringBuilder(newWord);
            
            for (int i = 0; i < newWord.Length; i++)
            {
                if(IsEven(n))
                {
                    newWord2[0] = 'y';
                }
            }
            newWord = newWord2.ToString();

            Console.WriteLine(newWord);
            return newWord;
        }

        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}