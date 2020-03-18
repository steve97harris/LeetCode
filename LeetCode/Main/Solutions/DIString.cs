using System;

namespace LeetCode.Main.Solutions
{
    public static class DIString
    {
        public static int[] DiStringMatch(string s)
        {
            int n = s.Length;
            int[] a = new int[n + 1];
            a[0] = 0;
            
            for (int i = 0; i < n; i++)
            {
                a[i+1] = a[i] + 1;
            }

            for (int i = 0; i < a.Length -1; i++)
            {
                if (s[i] == 'I')
                {
                    bool isIncrease = a[i] < a[i + 1];
                    if (!isIncrease)
                    {
                        // ++a[i+1];
                    }
                }
                else
                {
                    bool isDecrease = a[i] > a[i + 1];
                    if (!isDecrease)
                    {
                        // ++a[i];
                    }
                }
            }
            
            

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            return a;
        }
    }
}