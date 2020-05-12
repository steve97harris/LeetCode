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
            var lastValidPoints = 0;
            var lastValidPointsList = new List<int>();
            
            for (int i = 0; i < ops.Length; i++)
            {
                int.TryParse(ops[i], out var result);

                switch (ops[i])
                {
                    case "C":
                    {
                        currentPoints -= lastValidPoints;
                        lastValidPointsList.Remove(lastValidPoints);
                        if (lastValidPointsList.Count != 0)
                            lastValidPoints = lastValidPointsList[^1];
                        break;
                    }
                    case "D":
                        currentPoints += 2 * lastValidPoints;
                        lastValidPoints = 2 * lastValidPoints;
                        break;
                    case "+":
                        currentPoints += lastValidPointsList[^1] + lastValidPointsList[^2];
                        lastValidPoints = lastValidPointsList[^1] + lastValidPointsList[^2];
                        break;
                    default:
                        currentPoints += result;
                        lastValidPoints = result;
                        break;
                }
                lastValidPointsList.Add(lastValidPoints);
                

                Console.WriteLine(currentPoints);
            }

            return currentPoints;
        }
    }
}