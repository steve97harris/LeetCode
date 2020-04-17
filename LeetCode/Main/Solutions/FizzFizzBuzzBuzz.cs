using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class FizzFizzBuzzBuzz
    {
        public static IList<string> FizzBuzz(int n)
        {
            var fizzBuzz = new List<string>();
            
            for (int i = 1; i <= n; i++)
            {
                var word = i.ToString();
                if (i % 3 == 0 && i % 5 != 0)
                {
                    word = "Fizz";
                    fizzBuzz.Add(word);
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    word = "Buzz";
                    fizzBuzz.Add(word);
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    word = "FizzBuzz";
                    fizzBuzz.Add(word);
                }
                else
                {
                    fizzBuzz.Add(word);
                }
            }

            foreach (var s in fizzBuzz)
            {
                Console.WriteLine(s);
            }
            return fizzBuzz;
        }
    }
}