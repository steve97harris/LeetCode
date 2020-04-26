using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class MyQueue
    {
        private Stack<int> _stackQueue;
        private Stack<int> _stackHelper;
        
        public MyQueue()
        {
            
        }

        public void Push(int x)        // Push element to back of queue
        {
            _stackQueue.Push(x);
        }

        public int Pop()                // Removes and returns element in front of queue
        {
            Peek();
            _stackHelper.Pop();

            return _stackQueue.Peek();
        }

        public int Peek()                // Get the front element
        {
            if (_stackHelper.Count != 0)
                return _stackHelper.Peek();        // return front of helper if helper count not zero

            while (_stackQueue.Count != 0)
            {
                _stackHelper.Push(_stackQueue.Pop());        // while queue count is not zero, push the element at the front of the queue to the helper stack
            }
            
            return _stackHelper.Peek();            // return front of helper
        }

        public bool Empty()            // Returns whether the queue is empty
        {
            return _stackQueue.Count + _stackHelper.Count == 0;
        }
    }
}