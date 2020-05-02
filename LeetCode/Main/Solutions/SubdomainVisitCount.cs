using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class SubdomainVisitCount
    {
        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            var subDomainVisitsDic = new Dictionary<string,int>();
            var domainsWithVisits = new Dictionary<string, int>();

            for (int i = 0; i < cpdomains.Length; i++)
            {
                var numStringSplit = cpdomains[i].Split(' ');
                if (!domainsWithVisits.ContainsKey(numStringSplit[1]))
                    domainsWithVisits.Add(numStringSplit[1],int.Parse(numStringSplit[0]));
                else
                    domainsWithVisits[numStringSplit[1]] += int.Parse(numStringSplit[0]);
            }

            foreach (var (key, value) in domainsWithVisits)
            {
                var indexOfFirstDot = key.IndexOf(".", StringComparison.Ordinal);
                var indexOfLastDot = key.LastIndexOf(".", StringComparison.Ordinal);

                var subDomainA = new string(key.Take(key.Length).ToArray());
                var subDomainB = new string(key.Skip(indexOfFirstDot + 1).Take(key.Length - indexOfFirstDot + 1).ToArray());
                
                if (!subDomainVisitsDic.ContainsKey(subDomainA))
                    subDomainVisitsDic.Add(subDomainA, value);
                else
                    subDomainVisitsDic[subDomainA] += value; 
                
                if (!subDomainVisitsDic.ContainsKey(subDomainB))
                    subDomainVisitsDic.Add(subDomainB, value);
                else
                    subDomainVisitsDic[subDomainB] += value; 

                
                if (indexOfFirstDot == indexOfLastDot) continue;
                
                var subDomainC = new string(key.Skip(indexOfLastDot+1).Take(key.Length - indexOfLastDot + 1).ToArray());
                
                if (!subDomainVisitsDic.ContainsKey(subDomainC))
                    subDomainVisitsDic.Add(subDomainC, value);
                else
                    subDomainVisitsDic[subDomainC] += value; 
            }


            return subDomainVisitsDic.Select(pair => new string(pair.Value + " " + pair.Key)).ToList();
        }
    }
}