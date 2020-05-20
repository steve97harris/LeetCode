using System;

namespace LeetCode.Main
{
    public static class NeedleInAHaystack
    {
        public static int StrStr(string haystack, string needle)
        {
            if (!haystack.Contains(needle)) 
                return -1;
            
            var index = haystack.IndexOf(needle, StringComparison.Ordinal);
            return index;
        }
    }
}