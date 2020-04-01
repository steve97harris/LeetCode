using System;

namespace LeetCode.Main.Solutions
{
    public static class StringSplit
    {
        public static int BalancedStringSplit(string s)
        {
            int numberOfBalancedStrings = 0;
            const char r = 'R';
            const char l = 'L';

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])   
                {
                    case r:
                        ++numberOfBalancedStrings;
                        continue;
                    case l: 
                        --numberOfBalancedStrings;
                        continue;
                    default:
                        continue;
                }
            }


            // Console.WriteLine(numberOfRLs);
            return numberOfBalancedStrings;
        }
    }
}