using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class CombinationIterator
    {
        private List<string> permutations = new List<string>();
        public CombinationIterator(string characters, int combinationLength)
        {
            Permutation(characters, "", combinationLength);

            for (int i = 0; i < permutations.Count; i++)
            {
                var charArr = permutations[i].ToArray();
                if (!IsInOrderAndDoesNotContainDuplicates(charArr))
                {
                    permutations.Remove(permutations[i]);
                    i--;
                }
            }

            foreach (var sPermutation in permutations)
            {
                Console.WriteLine(sPermutation);
            }
        }
        
        private void Permutation(string str, string prefix, int lengthOfPermutationString)
        {
            if (prefix.Length == lengthOfPermutationString)
            {
                permutations.Add(prefix);
            }
            else
            {
                for (int i = 0; i < str.Length; i++) 
                {
                    Permutation(str, prefix + str[i], lengthOfPermutationString);
                }
            }
        }

        private bool IsInOrderAndDoesNotContainDuplicates(char[] arr)
        {
            var cloneArr = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                cloneArr[i] = arr[i];
            }
            
            Array.Sort(cloneArr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (cloneArr[i] != arr[i])
                    return false;

                if (i >= 1 && arr[i] == arr[i - 1])        // check duplicates
                    return false;
            }

            return true;
        }
        
        public string Next()
        {
            var nextString = permutations[0];
            permutations.RemoveAt(0);
            return nextString;
        }

        public bool HasNext()
        {
            return permutations.Count != 0;
        }
    }
}