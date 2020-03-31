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
                // Subdomain Visit Count:
                // string[] slkd = {"900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"};
                // SubdomainVisitCount.SubdomainVisits(slkd);

                // // Words That Can Be Formed By Characters: 
                // string[] words = {"hello","world","leetcode"};
                // string chars = "welldonehoneyr";
                // WordsThatCanBeFormedByCharacters.CountCharacters(words, chars);

                // // Min Steps For Anagram:
                // string s = "anagram", t = "mangaar";
                // MinNumOfStepsForAnagram.MinSteps(s, t);

                // ShortestToChar: 
                // string s = "loveleetcode";
                // char c = 'e';
                // ShortestDistanceToACharacter.ShortestToChar(s, c);

                string[] A = { "cool","lock","cook" };
                FindCommonCharacters.CommonChars(A);
            }
        }
    }
}