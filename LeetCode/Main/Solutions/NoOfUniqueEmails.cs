using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class NoOfUniqueEmails
    {
        public static int NumUniqueEmails(string[] emails)
        {
            List<string> uniqueEmailsList = new List<string>();

            for (int i = 0; i < emails[i].Length; i++) 
            { 
                while (i < emails[i].IndexOf('@')) 
                { 
                    if (emails[i].Contains('+')) 
                    { 
                        uniqueEmailsList.Add(emails[i].Remove(emails[i].IndexOf('+'), emails[i].IndexOf('@') - emails[i].IndexOf('+')));
                    }
                } 
            }

            // foreach (var xEmail in emails)
            // {
            //     uniqueEmailsList.Add(xEmail);
            // }

            foreach (var x in uniqueEmailsList)
            {
                Console.WriteLine(x);
            }

            return uniqueEmailsList.Count;
        }
    }
}