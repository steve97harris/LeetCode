using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class StevesStack
    {
        private int topElement;
        private Queue<int> stack1;
        private Queue<int> stackTop;
        public StevesStack()
        {
            stack1 = new Queue<int>();
            stackTop = new Queue<int>();
        }

        public void Push(int x)        // push element onto stack
        {
            topElement = x;
            if (stackTop.Count == 0)
                stackTop.Enqueue(x);
            stackTop.Dequeue(); 
            stackTop.Enqueue(x);
            stack1.Enqueue(x);
        }

        public int Pop()        // removes and returns element on top of stack
        {
            //stackTop.Dequeue();
            Console.WriteLine("pop - " + topElement);
            return topElement;
        }

        public int Top()        // returns the top element 
        {
            return topElement;
        }

        public bool Empty()        // return whether stack is empty 
        {
            return stack1.Count == 0;
        }

        public void DisplayQueues()
        {
            Console.WriteLine("stack1");
            foreach (var i in stack1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("stackTop");
            foreach (var ci in stackTop)
            {
                Console.WriteLine(ci);
            }
        }
    }
}