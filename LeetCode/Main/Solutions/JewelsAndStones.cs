using System;

namespace LeetCode
{
    public class JewelsAndStones
    {
        static int NumJewelsInStones(string J, string S)
        {
            int jewels = 0;
            foreach (char x in S)
            {
                foreach (char y in J)
                {
                    if (y == x)
                    {
                        ++jewels;
                    }
                }
            }
            Console.WriteLine(jewels);
            return jewels;
        }
    }
}