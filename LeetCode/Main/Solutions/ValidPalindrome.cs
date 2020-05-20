using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode.Main
{
    public static class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            var sArr = s.Where(char.IsLetterOrDigit).ToArray();
            s = string.Join("", sArr);
            s = s.ToLower();
            
            var rev = new string(s.Reverse().ToArray());
            rev = rev.ToLower();

            return rev == s;
        }
    }
}