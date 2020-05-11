using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class StevesStack
    {
        private Queue<int> queue;
        public StevesStack()
        {
            queue = new Queue<int>();
        }

        public void Push(int x)        // push element onto stack
        {
            queue.Enqueue(x);
            queue = new Queue<int>(queue.Reverse());
        }

        public int Pop()        // removes and returns element on top of stack
        {
            return queue.Dequeue();
        }

        public int Top()        // returns the top element 
        {
            return queue.Peek();
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