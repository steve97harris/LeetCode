using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Solutions
{
    public static class DecryptStringFromLettersToNumbers
    {
        public static string FreqAlphabets(string s)
        {
            string numbers = "0123456789";
            string[] numbers2 = {"10#","11#","12#","13#","14#","15#","16#","17#","18#","19#","20#","21#","22#","23#","24#","25#","26#"};
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            
            Dictionary<string, char> dictionary = new Dictionary<string, char>();
            List<string> result = new List<string>();

            for (int i = 0; i < numbers.Length; i++)
            {
                dictionary.Add(numbers[i].ToString(),alphabet[i]);
                
                if (s.Contains(numbers[i]))
                {
                    dictionary.TryGetValue(numbers[i].ToString(), out char value);    // if dictionary contains key (stringDigit), return corresponding value.
                    result.Add(value.ToString());
                }
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                dictionary.Add(numbers2[i], alphabet[i + numbers.Length -1]);
            }

            foreach (var x in dictionary)
            {
                Console.WriteLine(x);
            }

            int hashPosition = s.IndexOf('#'); 
            string hashNumberInS = s.Substring(hashPosition - 2, 3);
            Console.WriteLine("Hash numbers in String S = " + hashNumberInS);

            if (s.Contains(hashNumberInS))
            {
                dictionary.TryGetValue(hashNumberInS, out char hashValue);
                result.Add(hashValue.ToString());
            }

            s = string.Join("", result);
            
            Console.WriteLine(s);
            return s;
        }
    }
}