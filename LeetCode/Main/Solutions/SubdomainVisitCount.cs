using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SubdomainVisitCount
    {
        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, string> subDomainsWithVisits = new Dictionary<string, string>();
            IList<string> subDomains = new List<string>();

            for (int i = 0; i < cpdomains.Length; i++)
            {
                String[] numStringSplit = cpdomains[i].Split(' ');
                subDomainsWithVisits.Add(numStringSplit[0],numStringSplit[1]);
            }

            int numOfDots = 0;
            List<string> x = new List<string>();
            foreach (KeyValuePair<string,string> pair in subDomainsWithVisits)
            {
                for (int i = 0; i < pair.Value.Length; i++)
                {
                    if (pair.Value[i] == '.')
                    {
                        ++numOfDots;
                    }
                }
            }

            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine(x[i]);
            }
            return subDomains;
        }
    }
}