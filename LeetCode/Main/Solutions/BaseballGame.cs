using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class BaseballGame
    {
        public static int CalPoints(string[] ops)
        {
            var currentPoints = 0;
            var lastValidPointsList = new List<int>();
            
            for (int i = 0; i < ops.Length; i++)
            {
                int.TryParse(ops[i], out var result);

                switch (ops[i])
                {
                    case "C":
                    {
                        if (lastValidPointsList.Count == 0)
                            continue;
                        
                        currentPoints -= lastValidPointsList[^1];
                        lastValidPointsList.RemoveAt(lastValidPointsList.Count - 1);
                        break;
                    }
                    case "D":
                        if (lastValidPointsList.Count == 0)
                            continue;
                        
                        currentPoints += 2 * lastValidPointsList[^1];
                        lastValidPointsList.Add(2 * lastValidPointsList[^1]);
                        break;
                    case "+":
                        if (lastValidPointsList.Count < 2)
                            continue;
                        
                        currentPoints += lastValidPointsList[^1] + lastValidPointsList[^2];
                        lastValidPointsList.Add(lastValidPointsList[^1] + lastValidPointsList[^2]);
                        break;
                    default:
                        currentPoints += result;
                        lastValidPointsList.Add(result);
                        break;
                }


                Console.WriteLine(currentPoints);
            }

            return currentPoints;
        }
    }
}