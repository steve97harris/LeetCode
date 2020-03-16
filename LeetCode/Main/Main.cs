using System;
using LeetCode.Main.Solutions;

namespace LeetCode.Main
{
    public static class RunMe
    {
        static void Main()
        {
            // int[][] people = {new int[] {7, 0}, new int[] {4, 4}, new int[] {7, 1}, new int[] {5, 0}, new int[] {6, 1}, new int[] {5, 2}};
            // QueueReconstructionByHeight.ReconstructQueue(people);

            int[] T = {73, 74, 75, 71, 69, 72, 76, 73};
            DailyTemperatures.DailyTemps(T);
        }
    }
}