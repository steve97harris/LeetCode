using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class NoOfUniqueEmails
    {
        public static int NumUniqueEmails(string[] emails)
        {
            List<string> uniqueEmailsList = new List<string>();

            for (int i = 0; i < emails.Length; i++)
            {
                int atIndex = emails[i].IndexOf('@');
                string local = emails[i].Substring(0, atIndex);
                string domain = emails[i].Substring(atIndex);

                if (local.Contains('+'))
                {
                    local = local.Substring(0, local.IndexOf('+'));
                }

                local = local.Replace(".", "");
                if (!uniqueEmailsList.Contains(local + domain))
                {
                    uniqueEmailsList.Add(local + domain);
                }
            }

            foreach (var x in uniqueEmailsList)
            {
                Console.WriteLine(x);
            }

            return uniqueEmailsList.Count;
        }
    }
}