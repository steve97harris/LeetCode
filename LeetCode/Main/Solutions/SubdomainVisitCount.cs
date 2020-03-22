﻿using System;
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

                domainsList.Add(xCpdomain.Substring(0,xCpdomain.IndexOf(" ")) + " " + Subdomain(xCpdomain));
                
                domainsList.Add(xCpdomain.Substring(0,xCpdomain.IndexOf(" ")) + " " + SubSubDomain(xCpdomain));
            }

            foreach (var x in domainsList)
            {
                Console.WriteLine(x);
            }

            return domainsList;
        }

        public static string Subdomain(string x)
        {
            x = x.Substring(x.IndexOf(".") + 1, x.Length - x.IndexOf(".") - 1);
            return x;
        }

        public static string SubSubDomain(string x)
        {
            x = x.Substring(x.LastIndexOf(".") + 1, x.Length - x.LastIndexOf(".") - 1);
            return x;
        }
    }
}