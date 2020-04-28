using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.CodingTestYR
{
    public static class CodingTest
    {
        public static int GetQueueTime(int[] A)
        {
            var totalTime = 0;
            foreach (var num in A)
            {
                if (num == 0 && totalTime < A.Length && totalTime != 0)
                    totalTime += 1;
                else
                    totalTime += num;
            }
            
            Console.WriteLine(totalTime);
            return totalTime;
        }

        public static int GetQueueTimeWithPrinters(int[] A, int[] P)
        {
            // P - array of printers, contains the number of prints that a printer can complete per second:
            // E.g: 
            // P = { 2, 3, 1 }, implies 3 printers:
            // The first: 2 prints per second
            //     second: 3 prints per second
            //     third: 1 print per second
            // All printers may print at the same time

            var totalTimeForPrinter0 = 0;
            var totalTimeForPrinter1 = 0;

            var minPrintTimeAtPrinter0 = 0;
            var minPrintTimeAtPrinter1 = 0;

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Second " + i);
                var printers = new int[2];
                for (int j = 0; j < P.Length; j++)
                {
                    var printTime = Math.Ceiling((decimal) A[i] / P[j]);
                    printers[j] = (int) printTime;
                    
                    if (i == 0)
                    {
                        Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                        Console.WriteLine("printTime = " + printTime);
                        Console.WriteLine();
                    }

                    if (i < 1) continue;
                    var waitTime = 0;
                    if (j == 0)
                    {
                        waitTime = minPrintTimeAtPrinter0 > 0 ? minPrintTimeAtPrinter0 : 0;

                        printers[j] = (int) printTime + waitTime;
                    }
                    else
                    {
                        waitTime = minPrintTimeAtPrinter1 > 0 ? minPrintTimeAtPrinter1 : 0;

                        printers[j] = (int) printTime + waitTime;
                    }
                        

                    Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                    Console.WriteLine("printTime = " + printTime + ", waitTime = " + waitTime);
                    Console.WriteLine();
                }
                var minPrintTime = printers.Min();

                var minPrintTimeIndex = printers[0] == minPrintTime ? 0 : 1;
                if (minPrintTimeIndex == 0)
                {
                    minPrintTimeAtPrinter0 = minPrintTime;
                    
                    if (totalTimeForPrinter0 < minPrintTimeAtPrinter0 + i)
                        totalTimeForPrinter0 = minPrintTimeAtPrinter0 + i;         // !!??
                }
                else
                {
                    minPrintTimeAtPrinter1 = minPrintTime;
                    
                    if (totalTimeForPrinter1 < minPrintTimeAtPrinter1 + i)
                        totalTimeForPrinter1 = minPrintTimeAtPrinter1 + i;        // !!??
                }

                
                if (minPrintTimeAtPrinter0 > 0)
                {
                    minPrintTimeAtPrinter0 -= 1;
                }

                if (minPrintTimeAtPrinter1 > 0)
                {
                    minPrintTimeAtPrinter1 -= 1;
                }
                
                
                Console.WriteLine("Send order to printer at index: " + minPrintTimeIndex);
                Console.WriteLine("** minPrintTime = " + minPrintTime);
                Console.WriteLine("------");
            }
            
            Console.WriteLine("P[0] finishes at: " + totalTimeForPrinter0);
            Console.WriteLine("P[1] finishes at: " + totalTimeForPrinter1);
            
            
            return Math.Max(totalTimeForPrinter0,totalTimeForPrinter1); 
        }

        public static int GetUnorderedQueueTimeWithPrinters(int[] A, int[] P)
        {
            return 0;
        }
    }
}