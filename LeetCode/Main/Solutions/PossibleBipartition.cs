using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class PossibleBiPartition
    {
        private static List<int> group1 = new List<int>();
        private static List<int> group2 = new List<int>();
        public static bool PossibleBipartition(int N, int[][] dislikes)
        {
            if (dislikes.Length == 0)
                return true;
            
            for (int i = 0; i < dislikes.Length; i++)
            {
                AddToGroup(dislikes[i][0], dislikes[i][1]);
                AddToGroup(dislikes[i][1], dislikes[i][0]);
            }

            var bothGroups = group1.Concat(group2).ToList();

            Console.WriteLine("Group 1: ");
            foreach (var i in group1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Group 2: ");
            foreach (var i in group2)
            {
                Console.WriteLine(i);
            }

            if (ContainsDuplicates(bothGroups))
            {
                Console.WriteLine("false");
                return false;
            }

            for (int i = 0; i < N; i++)
            {
                if (!bothGroups.Contains(i + 1))
                    return false;
            }
            
            Console.WriteLine("true");
            return true;

        }

        private static bool ContainsDuplicates(List<int> arr)
        {
            var distinct = arr.Distinct().ToList();
            var distinctString = string.Join("", distinct);
            var arrString = string.Join("", arr);
            return arrString != distinctString;
        }

        private static void AddToGroup(int person0, int person1)
        {
            if (group1.Contains(person0) && !group2.Contains(person1))
            {
                group2.Add(person1);
            }

            if (group2.Contains(person0) && !group1.Contains(person1))
            {
                group1.Add(person1);
            }

            var bothGroups = group1.Concat(group2).ToList();
            if (bothGroups.Contains(person0) || bothGroups.Contains(person1)) 
                return;
            
            group1.Add(person0);
            group2.Add(person1);
        }
    }
}