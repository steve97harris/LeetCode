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
            foreach (string word in strgs)
            {
                foreach (char x in word)
                { 
                    Console.WriteLine(x); 
                }
            }
        }
    }
}