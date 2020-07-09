using System;
using System.Linq;

namespace LeetCode.Main
{
    public class DesignStackWithIncrementOperation
    {
        private int[] customStack;
        public DesignStackWithIncrementOperation(int maxSize)
        {
            customStack = new int[maxSize];
            for (int i = 0; i < customStack.Length; i++)
            {
                customStack[i] = -1;
            }
        }

        public void Push(int x)
        {
            for (int i = 0; i < customStack.Length; i++)
            {
                if (customStack[i] != -1) 
                    continue;
                
                customStack[i] = x;
                break;
            }
            
            foreach (var i in customStack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----");
        }

        public int Pop()
        {
            var popNum = -1;
            for (int i = 0; i < customStack.Length; i++)
            {
                if (!customStack.Contains(-1))
                {
                    popNum = customStack[^1];
                    customStack[^1] = -1;
                    break;
                }

                if (customStack[i] != -1) 
                    continue;
                if (i == 0) 
                    continue;
                
                popNum = customStack[i - 1];
                customStack[i - 1] = -1;
                break;
            }
            
            Console.WriteLine("pop - " + popNum);
            foreach (var i in customStack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----");

            return popNum;
        }

        public void Increment(int k, int val)
        {
            for (int i = 0; i < Math.Min(customStack.Length, k); i++)
            {
                customStack[i] += val;
            }

            foreach (var i in customStack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----");
        }
    }
}