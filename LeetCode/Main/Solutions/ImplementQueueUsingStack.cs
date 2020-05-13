using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class ImplementQueueUsingStack
    {
        private Stack<int> backStack = new Stack<int>();
        private Stack<int> frontStack = new Stack<int>();
        public ImplementQueueUsingStack()
        {
            
        }
        
        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            while (frontStack.Count != 0)
                backStack.Push(frontStack.Pop());
            frontStack.Push(x);
            while (backStack.Count != 0)
                frontStack.Push(backStack.Pop());
        }
    
        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (frontStack.Count != 0)
                return frontStack.Pop();
            return -1;
        }
    
        /** Get the front element. */
        public int Peek()
        {
            if (frontStack.Count != 0)
                return frontStack.Peek();

            Console.WriteLine("peek = " + frontStack.Peek());
            return -1;
        }
    
        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return frontStack.Count == 0;
        }
    }
}