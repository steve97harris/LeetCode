using System;

namespace LeetCode.Main.Solutions
{
    public static class StringSplit
    {
        public static int BalancedStringSplit(string s)
        {
            int rCount = 0;
            int lCount = 0;
            int numberOfBalancedStrings = 0;
            const char r = 'R';
            const char l = 'L';

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == r)
                {
                    ++rCount;
                }
                else
                {
                    ++lCount;
                }

                if (rCount == lCount)
                {
                    ++numberOfBalancedStrings;
                    lCount = 0;
                    rCount = 0;
                }
            }

            
            return numberOfBalancedStrings;
        }
    }
}