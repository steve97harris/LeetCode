using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class BackspaceStringCompare
    {
        public static bool BackspaceCompare(string s, string t)
        {
            bool isEqual = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    s = s.Remove(i - 1, 2);
                }
                else if (s[i] == '#' && s[i+1] == '#')
                {
                    
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '#')
                {
                    t = t.Remove(i - 1, 2);
                }
            }

            
            if (s == t)
                isEqual = true;
            
            Console.WriteLine("s = " + s);
            Console.WriteLine("t = " + t);
            Console.WriteLine("Is Equal: " + isEqual);
            return isEqual;
        }
    }
}