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

            for (int i = 0; i > numbers.Length; i++)
            {
                foreach (string hashNumber in numbers2)
                {
                    dictionary.Add(hashNumber, alphabet[i]);
                }
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                if (s.Contains(numbers2[i]))
                {
                    dictionary.TryGetValue(numbers2[i], out char value);
                    result.Add(value.ToString());
                }
            }

            // foreach (char digit in s) 
            // {
            //     string stringDigit = digit.ToString();
            //     
            //     if (dictionary.TryGetValue(stringDigit, out char value))          
            //     { 
            //         stringDigit = value.ToString();
            //         result.Add(stringDigit);
            //     }
            //     else 
            //     { 
            //         Console.WriteLine("Invalid entry"); 
            //     }
            // }
            

            s = string.Join("", result);
            
            Console.WriteLine(s);
            return s;
        }
    }
}