using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            var res = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    var temp = GetSubstring(s, i, j);
                    if (!IsPalindrome(temp)) 
                        continue;
                    
                    
                    if (temp.Length > res.Length)
                        res = temp;
                }
            }

            Console.WriteLine(res);
            return res;
        }
        
        private static string GetSubstring(string str, int i, int j)
        {
            var newString = "";
            for (int k = i; k <= j; k++)
            {
                newString += str[k];
            }

            return newString;
        }

        private static bool IsPalindrome(string str)
        {
            var rev = new string(str.Reverse().ToArray());
            return str == rev;
        }
    }
}