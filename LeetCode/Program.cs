using System;

namespace LeetCode
{
    class Program
    {
        static void Main()
        {
            string[] strgs = {"Steve", "Steves"};
            LongestCommonPrefix(strgs);
        }
        
        static void LongestCommonPrefix(string[] strgs)
        {
            for (int i = 0; i < strgs.Length; i++)
            {
                char[] characterArray = strgs[i].ToCharArray();
                Console.WriteLine("{0}    {1}", characterArray[0], characterArray[1]);
            }
        }
    }
}