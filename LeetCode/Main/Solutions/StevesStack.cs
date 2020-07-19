using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class StevesStack
    {
        private int top;
        private Queue<int> queue;
        public StevesStack()
        {
            queue = new Queue<int>();
        }

        public void Push(int x)        // push element onto stack
        {
            top = x;
            queue.Enqueue(x);
        }

        public int Pop()        // removes and returns element on top of stack
        {
            queue= new Queue<int>(queue.Reverse());
            var dequeue = queue.Dequeue();
            if (!Empty())
                top = queue.Peek();
            queue = new Queue<int>(queue.Reverse());
            Console.WriteLine("pop - " + dequeue);
            return dequeue;
        }

        public int Top()        // returns the top element 
        {
            return top;
        }

        public bool Empty()        // return whether stack is empty 
        {
            return queue.Count == 0;
        }

        public void DisplayQueues()
        {
            Console.WriteLine("queue");
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
        }
    }
}