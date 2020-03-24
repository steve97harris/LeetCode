using System;
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

                // string[] emails =
                // {
                //     "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com",
                //     "testemail+david@lee.tcode.com"
                // };
                // NoOfUniqueEmails.NumUniqueEmails(emails);

                int[] arr1 = {2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19};
                int[] arr2 = {2, 1, 4, 3, 9, 6};
                RelativelySortArray.RelativeSortArray(arr1, arr2);
            }
        }
    }
}