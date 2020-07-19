using System;
using System.Collections.Generic;
using System.Threading;

namespace LeetCode.Main.Solutions
{
    public class FizzBuzzMultithreaded
    {
        private int n;
        private int cntCheck = 0;
        
        public FizzBuzzMultithreaded(int n) 
        {
            this.n = n;
        }

        // printFizz() outputs "fizz".
        public void Fizz(Action printFizz)
        {
            for (int i = 1; i <= n; i++)
            {
                Sync(i);
                if (i % 3 == 0 && i % 5 != 0)
                    printFizz();
            }
        }

        // printBuzzz() outputs "buzz".
        public void Buzz(Action printBuzz)
        {
            for (int i = 1; i <= n; i++)
            {
                Sync(i);
                if (i % 3 != 0 && i % 5 == 0)
                    printBuzz();
            }
        }

        // printFizzBuzz() outputs "fizzbuzz".
        public void Fizzbuzz(Action printFizzBuzz)
        {
            for (int i = 1; i <= n; i++)
            {
                Sync(i);
                if (i % 3 == 0 && i % 5 == 0)
                    printFizzBuzz();
            }
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Number(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                Sync(i);
                if (i % 3 != 0 && i % 5 != 0)
                    printNumber(i);
            }
        }

        private void Sync(int index)
        {
            // spin here until all threads are synced
            
            Interlocked.Increment(ref cntCheck);
            while (cntCheck < index * 4)
            {
                Thread.Sleep(1);
            }
        }
    }
}