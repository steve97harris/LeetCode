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
            
            var processingTimeLeftPerPrinter = new int[P.Length];

            for (int i = 0; i < A.Length; i++)
            {
                var printers = new int[2];
                     // ***
                var minPrintTime = 0;
                
                Console.WriteLine("Time Elapsed " + i);
                
                for (int j = 0; j < P.Length; j++)
                {
                    var printTimePerOrder = CeilingIntDivision(A[i], P[j]);
                    printers[j] = (int) printTimePerOrder;        // Ben says remove !?
                    
                    if (i == 0)
                    {
                        Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                        Console.WriteLine("printTime = " + printTimePerOrder);
                        Console.WriteLine();
                    }
                    
                    if (i < 1) continue;

                    // minPrintTime = j == 0 ? minPrintTimeAtPrinter0 : minPrintTimeAtPrinter1;
                    //if (j ==)
                    {
                        minPrintTime = processingTimeLeftPerPrinter[j];
                    }

                    // waitTime = minPrintTime > 0 ? minPrintTime : 0;

                    var waitTime = minPrintTime;
                    
                    printers[j] += waitTime;

                    Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                    Console.WriteLine("printTime = " + printTimePerOrder + ", waitTime = " + waitTime);
                    Console.WriteLine();
                }
                minPrintTime = printers.Min();

                var minPrintTimeIndex = -1;
                for (int k = 0; k < printers.Length; k++)
                {
                    if (printers[k] != minPrintTime) continue;
                    minPrintTimeIndex = k;
                    break;
                }
                // or
                // var keyIndex = printers.Select((v, i) => new {Val = v, Index = i})
                //     .FirstOrDefault(x => x.Val == printers.Min())?.Index ?? -1;

                var totalTimeWithCurrentOrder = new int[printers.Length];
                for (int l = 0; l < totalTimeWithCurrentOrder.Length; l++)
                {
                    totalTimeWithCurrentOrder[l] = printers[l] + processingTimeLeftPerPrinter[l];
                    Console.WriteLine("total time with current order: " + totalTimeWithCurrentOrder[l]);
                }

                processingTimeLeftPerPrinter[minPrintTimeIndex] += printers[minPrintTimeIndex];
                Console.WriteLine("min print time index: " + minPrintTimeIndex);
                Console.WriteLine("processing time left per printer: " + processingTimeLeftPerPrinter[minPrintTimeIndex]);

                for (int m = 0; m < processingTimeLeftPerPrinter.Length; m++)
                {
                    processingTimeLeftPerPrinter[m] = Math.Max(processingTimeLeftPerPrinter[m]--, 0);
                }

                Console.WriteLine("------");
            }
            
            
            Console.WriteLine("Max processing time: " + processingTimeLeftPerPrinter.Max());
            return processingTimeLeftPerPrinter.Max(); 
            // Correct answer is 7. 
        }

        private static decimal CeilingIntDivision(int a, int b)
        {
            return Math.Ceiling((decimal) a / b);
        }

        public static int GetUnorderedQueueTimeWithPrinters(int[] A, int[] P)
        {
            var listA = A.ToList();

            var totalTimeForPrinter0 = 0;
            var totalTimeForPrinter1 = 0;

            var minPrintTimeAtPrinter0 = 0;
            var minPrintTimeAtPrinter1 = 0;
            
            var second = 0;
            while (listA.Count != 0)
            {
                var minPrintTime = 0;
                
                var maxInA = listA.Max();
                var indexOfMaxA = 0;
                
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == maxInA)
                        indexOfMaxA = i;
                }
                    
                var printers = new int[2];
                for (int j = 0; j < P.Length; j++)
                {
                    var printTimePerOrder = Math.Ceiling((decimal) A[indexOfMaxA] / P[j]);
                    printers[j] = (int) printTimePerOrder;
                    
                    if (second == 0)
                    {
                        Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                        Console.WriteLine("printTime = " + printTimePerOrder);
                        Console.WriteLine();
                    }

                    if (second < 1) continue;
                    var waitTime = 0;
                    minPrintTime = j == 0 ? minPrintTimeAtPrinter0 : minPrintTimeAtPrinter1;

                    waitTime = minPrintTime > 0 ? minPrintTime : 0;
                    printers[j] = (int) printTimePerOrder + waitTime;
                        

                    Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                    Console.WriteLine("printTime = " + printTimePerOrder + ", waitTime = " + waitTime);
                    Console.WriteLine();
                }
                
                minPrintTime = printers.Min();

                var minPrintTimeIndex = printers[0] == minPrintTime ? 0 : 1;
                if (minPrintTimeIndex == 0)
                {
                    minPrintTimeAtPrinter0 = minPrintTime;
                    
                    if (totalTimeForPrinter0 < minPrintTimeAtPrinter0 + second)
                        totalTimeForPrinter0 = minPrintTimeAtPrinter0 + second;         // !!??
                }
                else
                {
                    minPrintTimeAtPrinter1 = minPrintTime;
                    
                    if (totalTimeForPrinter1 < minPrintTimeAtPrinter1 + second)
                        totalTimeForPrinter1 = minPrintTimeAtPrinter1 + second;        // !!??
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
                    
                listA.Remove(maxInA);
                second++;
            }
            
            Console.WriteLine("P0 finishes at second: " + totalTimeForPrinter0);
            Console.WriteLine("P1 finishes at second: " + totalTimeForPrinter1);

            return Math.Max(totalTimeForPrinter0,totalTimeForPrinter1);
        }
    }
}