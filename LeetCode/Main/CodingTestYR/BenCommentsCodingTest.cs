using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.CodingTestYR
{
    /* Up here are my general thoughts etc. - These are by no means what we do on a daily basis, but
     * are hopefully useful tips and best practices - we should really be better but y'know, time
     * pressure!
     *
     * Any comments in the code I've made and labelled 'Ben - '
     *
     * Quesion 1 - looked good to me! I've put an example summary which are useful for everyone involved!
     * (I've started to do this in our YR stuff, helps a lot when looking at code you didn't write!)
     * Variables well named and initialised, can't see anything wrong with the approach. Runtime is O(N),
     * and I can't see anything better than that for this question
     *
     * Question 2 - I've delved quite in depth in the comments with this one. The approach was correct -
     * you've iterated over the orders, and then processed each printer based on how efficient they are
     * and made an attempt to select the fastest. You can see as I've looked through it, I was worried
     * you had condensed the problem down to two printers, which turned out half true. Might be worth
     * having a go doing some alterations based off what I've added as comments?
     *
     * Question 3 - I've not gone in depth yet. From a quick look, it looks as though your approach is to find the index
     * of the max order size, and handle it, and remove it from the pool of orders. I like this approach as it
     * copes with the pool of orders being added to as we process prints - great! I would then say, why not do this
     * 'while loop' approach with the question above? It seems like you've used two different ways to iterate for
     * both questions, though the questions are largely similar...? I can see why, but just something to think about!
     *
     * Good stuff:
     *
     * Looks like your syntax and knowledge of C# is improving! Use of var, inline 'if' statements (?),
     * etc. is better and you can see how it cuts down the code
     *
     * Question 1 was as I would expect, it's covered some of the edge cases and people have previously
     * tried to look good and submitted one line solutions which look nice and trim, but actually don't
     * work with some of the more odd orders. As far as I can see yours covers them!
     * 
     * Suggestions:
     *      
     * Would have been good to see comments through the code to give an understanding of what you were
     * doing / thought process. I suppose if you were submitting this as an actual tech test, it gives
     * the reviewer an easier time reading this (and trust me, it gets boring reading a lot of them so
     * it's nice to have them commented to make my life easier!) and also if you've not got something
     * quite right, but you've commented what it should be doing, then it shows you intentions were
     * correct at least which could be useful!
     *
     * Have a look through what I've said about changing this away from a two-printer solution towards a
     * better solution with any number of printers. I'd say what you have is half way toward doing this,
     * but not quite there!
     *
     * One thing I always ask about in interviews is this: if you were make this problem more object orientated,
     * how would you do that? What kinds of classes could you extract? This fits the bill as asked, but
     * submitting something which is more scalable, OOP, etc is worth having a think about!
     *
     * Sorry for the amount of comment I've added - partly out of boredom, but also I think it's useful to
     * pick it apart even if it feels like I'm personally attacking you, which is always how I feel when
     * people pick apart my code. It's easier to focus and highlight and comment on the areas which need work
     * rather than the good stuff, but improving the bad stuff is the most useful thing. Overall I can see
     * it's got a lot of the right structure and the approach is correct, so don't worry!
     */
    public static class CodingTestBensComments
    {
        /// <summary>
		/// Ben - If you didn't know you can do summary of functions by typing '///' above them, it looks like
		/// this is what you wanted to do for question 2? It also lets you give parameter definitions etc.
		/// </summary>
		/// <param name="A">Example: "Array of orders per second to the printer"</param>
		/// <returns></returns>
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

            // Ben - the above is probably for your reference, but could have been good to turn into a summary
            // for the function itself

            // Ben - first impression of these variables is that you have two printers in the question, called
            // '0' and '1'. Immediately I've assumed (rightly or wrongly!) that this has limited this function
            // to only work with 2 printers, and not a variable amount as required by the question. Obvs I'll
            // read on and see, but my immediate thoughts are 'this isn't gonna work with anything other than
            // two printers...!
            var totalTimeForPrinter0 = 0; 
            var totalTimeForPrinter1 = 0;
            var printerFinishingTimes = new int[2];
            var totalTimeForPrinter = 0;

            var minPrintTimeAtPrinter0 = 0;
            var minPrintTimeAtPrinter1 = 0;
            var minPrintTimeAtPrinter = 0;

            // Ben - I know I've said this at the top, but a comment here of 'Iterating over the orders' or
            // something like that would just make the readers life easier in understanding what you're doing
            // - I know that two arrays are the focus of this question, but it immediately lets me know which
            // one this is without having to look for myself!
            for (int i = 0; i < A.Length; i++)
            {
                var printers = new int[2];
                var minPrintTime = 0;

                // Ben - I'm being picky here, but something like 'Time elapsed' may be better? Slightly more
                // descriptive!
                Console.WriteLine("Second " + i); 

                // Ben - again, just a comment here to let reader know what is being iterated over is nice
                for (int j = 0; j < P.Length; j++)
                {
                    // Ben - probably not necessary for this exercise but more of a general tip - something
                    // like these next two lines could be extracted into a function of its own. It's not large,
                    // but I get the feeling in a scenario like this one, it could be used all over the place
                    // so it would provide some reuse, but also the function name can give an idea of what is
                    // being achieved. Personally, I think the line:
                    //
                    // var printTimePerOrder = CeilingIntDivision(A[i], P[j]);
                    //
                    // cuts out some code in this large function, but is also descriptive of what is going on?
                    // You could add the '///' Summary to the function, describe the parameters, and gives
                    // great clarity and how to use it!
                    // (Probably not the best function name in the world but you get the point ha)
                    var printTimePerOrder = Math.Ceiling((decimal) A[i] / P[j]);
                    printers[j] = (int) printTimePerOrder;

                    // Ben - These two 'if' statements that follow should be able to be rolled into one, no? Something
                    // like:
                    // if (i == 0)
                    // { 
                    //   Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                    //   Console.WriteLine("printTime = " + printTimePerOrder);
                    //   Console.WriteLine();
                    //   Continue;
                    // }
                    // i can never be below 0 anyway so this works
                    if (i == 0)
                    {
                        Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                        Console.WriteLine("printTime = " + printTimePerOrder);
                        Console.WriteLine();
                    }

                    if (i < 1) continue;
                    var waitTime = 0;

                    minPrintTime = j == 0 ? minPrintTimeAtPrinter0 : minPrintTimeAtPrinter1;

                    // Ben - this line below, I'm not sure what the point of it is? Do we need the 'waitTime'
                    // variable at all? Unless 'minPrintTime' can go below 0, this line below is redundant and
                    // you can just set
                    //
                    // waitTime = minPrintTime;
                    //
                    // All this does currently is check if minPrintTime is 0 or less, and then if it's not,
                    // keep it the same, and if it is, set it to 0, so unless minPrintTime can go below 0
                    // (and I'd be confused if it could!) then this is unnecessary. Which I would then argue
                    // makes the 'waitTime' variable unnecessary as well, you could just use minPrintTime in
                    // place of it all!
                    //
                    // If for some reason minPrintTime could go below 0, a better way to write this function
                    // would be:
                    //
                    // waitTime = Math.Max(minPrintTime, 0);
                    //
                    // This is just a bit clearer in making sure you have no negative numbers!
                    waitTime = minPrintTime > 0 ? minPrintTime : 0;

                    // Ben - I would change this line to:
                    //
                    // printers[j] += waitTime;
                    //
                    // you've assigned 'printers[j]' to this value '(int)printTimePerOrder' at the beginning of
                    // this 'for' loop that iterates over j. So this line below effectively makes that assignment a
                    // waste of time! Alternatively, you could just delete that assignment above, this line here:
                    //
                    // printers[j] = (int) printTimePerOrder;
                    //
                    // I think this is probably the best approach, it clearly shows what this 'printers' array does -
                    // it contains the time to process the current order, plus any residual waiting time from other
                    // orders. Assigning to 'printers[j]' earlier up isn't super helpful!
                    printers[j] = (int) printTimePerOrder + waitTime;

                    Console.WriteLine("B[{0}] = {1}",j,printers[j]);
                    Console.WriteLine("printTime = " + printTimePerOrder + ", waitTime = " + waitTime);
                    Console.WriteLine();
                }
                
                minPrintTime = printers.Min();

                // Ben - up until here, I've followed what's going on and it's looked largely like the right approach.
                // Beyond this, I'm seeing what I was worried about at the top is correct, this whole thing looks like
                // you've taken the general problem of any amount of printers, and then you've condensed it down to
                // kind of focussing on two printers with this 'minPrintTimeIndex' only being 0 or 1. It's the right
                // idea to be getting the minimum index, but you have to check over the whole printer array for it.
                // A simple way of doing that would be something like:
                //
                // var minPrintTimeIndex = -1;
                //
                // for (int k = 0; k < printers.Length; k++)
                // {
                //   if ( printers[k] == minPrintTime)
                //   {
                //     minPrintTimeIndex = k;
                //     break;
                //   }
                // }
                //
                // but you could do this really nicely with linq as well:
                //
                // int keyIndex = printers.Select((v, i) => new { Val = v, Index = i })                
                //                        .FirstOrDefault(x => x.Val == printers.Min)?.Index ?? -1;
                //
                // Which will return -1 if the index doesn't exist (which won't happen!)
                // (I think this is right, not tested though, it's close if not correct ha)
                //
                // So now you have the min index, rather that just this 0 or 1 index value. What you need to be doing
                // here is adding the time taken to print this current order to the printer at this index. You've
                // mimicked what you need to do here with this 'totalTimeForPrinter0/1', which is showing you've
                // limited the problem to only two printers. The thing to do here would be to have created an array at
                // the beginning instead of these variables called:
                //
                // int[] processingTimeLeftPerPrinter = new int[P.Length];
                //
                // where you could store the remaining time each printer has left to process all orders assigned to it.
                // You could use largely the same logic as you've used here for two printers, but extend it over all of
                // them. Hence, you can get the index as highlighted above, but I think you should be getting the index
                // based on the 'processingTimeLeftPerPrinter + printers' arrays. The reason for this is that we want
                // to know where to assign the next order to not just based on which printer can print it fastest
                // (which is the 'printers' array) but also based on what each printer has left in its queue - if our
                // fastest printer (identified in the 'printers' array) has 2 years worth of orders to print, but a
                // printer which will take a second longer to print this given order has no queue, this is the one
                // we want to take on the job! So I would have another array, something like:
                //
                // int[] totalTimeWithCurrentOrder = new int[printers.Length];
                // for (int i = 0; i < totalTimeWithCurrentOrder.Length; i++)
                // {
                //   totalTimeWithCurrentOrder[i] = printers[i] + processingtimeLeftPerPrinter[i];
                // }
                //
                // this is what you want to get the min index to. Once you have the min index, you can increase the
                // correct index in your running total array (processingTimeLeftPerPrinter), eg:
                //
                // processingTimeLeftPerPrinter[minIndex] += printers[minIndex];
                //
                // This has now added the new order to your running total time for each printer, based on which
                // printer will increase the overall wait time the least!
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

                // Ben - this is the right thing to be doing, but obvs now we don't just do it for these two values,
                // we want to do it for all of the remaining printer times! So something like
                //
                // for (int i = 0; i < processingTimeLeftPerPrinter.Length; i++)
                // {
                //   processingTimeLeftPerPrinter[i] = Math.Max(processingTimeLeftPerPrinter[i]--, 0);
                // }
                //
                // Which also creates and solves the check for the print time going below 0, with the Math.Max, it
                // can't drop below 0.
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
            
            // Ben - And finally here, you want to be returning the max value of the 'processingTimeLeftPerPrinter'
            // array
            return Math.Max(totalTimeForPrinter0,totalTimeForPrinter1); 
        }

        // Ben - I don't think it's particularly useful for me to go through this one until the one above is sorted, as
        // they are largely the same problem! 
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