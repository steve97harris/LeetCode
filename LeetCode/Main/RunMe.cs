﻿using System;
using LeetCode.Main.Solutions;

namespace LeetCode.Main
{
    namespace LeetCode.Main
    {
        public static class RunMe
        {
            static void Main()
            {
                // string[] slkd = {"900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"};
                // SubdomainVisitCount.SubdomainVisits(slkd);

                string[] emails =
                {
                    "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com",
                    "testemail+david@lee.tcode.com"
                };
                NoOfUniqueEmails.NumUniqueEmails(emails);
            }
        }
    }
}