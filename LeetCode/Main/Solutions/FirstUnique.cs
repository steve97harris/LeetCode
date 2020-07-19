using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class FirstUnique
    {
        private class ListNode
        {
            public ListNode _next;
            public ListNode _prev;
            public int _val;

            public ListNode(int val)
            {
                _val = val;
                _next = null;
                _prev = null;
            }
        }
        
        private class StevesDynamicLinkedList
        {
            private ListNode _head;
            private ListNode _tail;

            public StevesDynamicLinkedList()
            {
                _head = new ListNode(-1);
                _tail = new ListNode(-1);

                _head._next = _tail;
                _tail._prev = _head;
            }

            public ListNode GetFirst()
            {
                return _head._next;         // ?
            }

            public bool IsEmpty()
            {
                return _head._next == _tail;
            }

            public void Remove(ListNode node)
            {
                var prev = node._prev;
                var next = node._next;
                prev._next = next;
                next._prev = prev;
            }

            public void Append(int num)
            {
                var node = new ListNode(num);
                var prev = _tail._prev;
                prev._next = node;
                node._next = _tail;
                _tail._prev = node;
                prev._prev = prev;
            }
        }

        private StevesDynamicLinkedList _keys;
        private Dictionary<ListNode, int> _map;

        public FirstUnique(int[] nums)
        {
            _keys = new StevesDynamicLinkedList();
            _map = new Dictionary<ListNode, int>();
        }

        public int ShowFirstUnique()
        {
            return 0;
        }

        public void Add(int value)
        {
            
        }
    }
}