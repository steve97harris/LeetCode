using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class BackspaceStringCompare
    {
        public static bool BackspaceCompare(string s, string t)
        {
            if (s == null || t == null)
                return false;

            var sBackspace = ApplyBackspace(s);
            var tBackspace = ApplyBackspace(t);

            return String.Compare(sBackspace, tBackspace, StringComparison.Ordinal) == 0;
        }

        private static string ApplyBackspace(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                var isBackspace = c == '#';        // isBackspace is true if c is #

                if (!isBackspace)
                {
                    stack.Push(c);        // insert c at top of stack
                    continue;
                }

                if (stack.Count > 0)
                {
                    stack.Pop();        // removes and returns object at top of stack.
                }
            }
            
            return new string(stack.ToArray());
        }
    }
}