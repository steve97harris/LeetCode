using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class BaseballGame
    {
        public static int CalPoints(string[] ops)
        {
            int result = 0;
            var pointsTally = new List<int>();
            var differenceBetweenPoints = new List<int>();
            
            for (int i = 0; i < ops.Length; i++)
            {
                if (int.TryParse(ops[i], out int points))
                {
                    result = result + points;
                    pointsTally.Add(result);
                }
                else switch (ops[i])
                {
                    case "+" when i >= 2:
                        result = result + pointsTally[i-1] - pointsTally[i - 2] + pointsTally[i-3] - pointsTally[i-4];
                        pointsTally.Add(result);
                        break;
                    case "D" when ops[i - 1] != "C":
                        result = result + pointsTally[i-1] * 2;
                        pointsTally.Add(result);
                        break;
                    case "C":
                        result = pointsTally[i - 2];
                        pointsTally.Add(result);
                        break;
                    case "D" when ops[i - 1] == "C":
                        int.TryParse(ops[i - 3], out int points2);
                        result = result + points2 * 2;
                        pointsTally.Add(result);
                        break;
                }
            }

            foreach (var i in pointsTally)
            {
                Console.WriteLine("Points Tally = " + i);
            }

            Console.WriteLine("Result: " + result);
            return result;
        }
    }
}