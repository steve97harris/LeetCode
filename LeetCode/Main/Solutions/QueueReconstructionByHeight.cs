using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class QueueReconstructionByHeight
    {
        public static int[][] ReconstructQueue(int[][] people)
        {
            // person: [h, k]
            // h = height of person
            // k = number of people in front of this person who have height greater than or equal to h. 
            
            List<int[]> peopleAsList = new List<int[]>();
            foreach (int[] x in people)
            {
                peopleAsList.Add(x);
            }
            
            List<int[]> reconstructedList = new List<int[]>();
            

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i][1] == 0 && people[i][0] < people[i+1][0])
                {
                    reconstructedList.Add(people[i]);
                    peopleAsList.Remove(people[i]);
                }
            }

            
            
            // Display in Console:
            Console.WriteLine("PeopleAsList: ");
            for (int i = 0; i < peopleAsList.Count; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("[{0},{1}]",peopleAsList[i][j], peopleAsList[i][j+1]);
                }
            }
            
            Console.WriteLine("Reconstruction: ");
            for (int i = 0; i < reconstructedList.Count; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("[{0},{1}]",reconstructedList[i][j], reconstructedList[i][j+1]);
                }
            }
            
            int[][] result = reconstructedList.ToArray();
            return result;
        }
    }
}