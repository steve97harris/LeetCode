using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class LinkedListNode
    {
        public int value;
        public LinkedListNode next;
    }

    public class FirstUnique
    {
        private LinkedListNode _root = new LinkedListNode();

        public FirstUnique(int[] nums)
        {
            foreach (var num in nums)
            {
                Add(num);
            }
        }

        public int ShowFirstUnique()
        {
            return UniqueElements(_root);
        }

        public void Add(int value)
        {
            var newNode = new LinkedListNode {value = value, next = _root};
            _root = newNode;
        }

        private int UniqueElements(LinkedListNode root)
        {
            var hash = new Dictionary<int,int>();

            for (LinkedListNode temp = root; temp != null; temp = temp.next)
            {
                if (hash.ContainsKey(temp.value))
                    hash[temp.value] += 1;
                else
                    hash.Add(temp.value,1);
            }

            var result = 0;
            var count = 0;
            for (LinkedListNode temp = root; temp != null; temp = temp.next)
            {
                if (hash[temp.value] != 1 || temp.value == 0) continue;
                Console.WriteLine("Value of freq 1: " + temp.value);
                count++;
                result = temp.value;
            }

            if (count == 0)
                return -1;

            Console.WriteLine(result);
            return result;
        }
    }
}