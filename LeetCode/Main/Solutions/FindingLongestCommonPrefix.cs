using System;
using System.Linq;

namespace LeetCode
{
    class FindingLongestCommonPrefix
    {
        static bool allContainsPrefix(string[] array, int arrayLength, string str, int start, int end)
        {
            for (int i = 0; i <= (arrayLength - 1); i++)        // Iterating over array up to arrayLength - 1
            {
                for (int j = start; j <= end; j++)        // Iterating over start to end of array
                {
                    if (array[i][j] != str[j])        // If each character in every string is not equal each character in one of the strings (say str = array[0])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        static string LongestCommonPrefix(string[] array)
        {
            int arrayLength = array.Length;
            int minLength = array.Min(x => x.Length);
            Console.WriteLine(minLength);

            string prefix = "";

            int low = 0, high = minLength;
            while (low <= high)
            {
                int midPoint = low + (high - low) / 2;        // Same as (low + high) / 2 but avoids overflow for large low and high

                if (allContainsPrefix(array, arrayLength, array[0], low, midPoint))        
                {
                    // If all the strings in the array contains this prefix, append (add/join) this substring to the answer.
                    prefix = prefix + array[0].Substring(low, midPoint + 1);
                    
                    // Now go for the right hand side
                    low = midPoint + 1;
                }
                else
                {
                    // Go to left hand side
                    high = midPoint - 1;
                }
            }

            return prefix;
        }

        // static int firstNumAboveTen(int[] numbers)
        // {
        //     // int number = -1;
        //     // for (int i = 0; i < numbers.Length; i++)
        //     // {
        //     //     if (numbers[i] > 10)
        //     //     {
        //     //         return numbers[i]
        //     //     }
        //     // }
        //     // return number;
        //
        //     return numbers.First(x => x > 10);
        // }
    }
}