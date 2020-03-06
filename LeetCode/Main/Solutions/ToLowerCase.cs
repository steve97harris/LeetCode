using System;

namespace LeetCode.Main.Solutions
{
    public static class ToLowerCase
    {
        public static string ToLower(string str)
        {
            string lower = str.ToLower();
            str = lower;
            
            Console.WriteLine(str);
            return str;
        }
    }
}