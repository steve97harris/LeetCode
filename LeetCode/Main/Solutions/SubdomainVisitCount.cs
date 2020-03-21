using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class SubdomainVisitCount
    {
        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            IList<string> domainsList = new List<string>();
            foreach (string xCpdomain in cpdomains)
            {
                domainsList.Add(xCpdomain);

                domainsList.Add(xCpdomain.Substring(0,xCpdomain.IndexOf(" ")) + xCpdomain.Substring(xCpdomain.IndexOf("."), xCpdomain.Length - xCpdomain.IndexOf(".")));
            }

            foreach (var x in domainsList)
            {
                Console.WriteLine(x);
            }

            return domainsList;
        }
    }
}