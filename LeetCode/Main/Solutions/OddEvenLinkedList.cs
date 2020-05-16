using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class OddEvenLinkedList
    {
        private static ListNode newHead;
        private static List<int> evens = new List<int>();        // position in linked list, NOT value
        private static List<int> odds = new List<int>();
        public static ListNode OddEvenList(ListNode head)
        {
            SplitToOddsAndEvens(head, 1);
            if (odds.Count != 0)
            {
                for (int i = 0; i < odds.Count; i++)
                {
                    AddNodeToList(odds[i]);
                    Console.WriteLine(odds[i]);
                }
            }
            if (evens.Count != 0)
            {
                for (int i = 0; i < evens.Count; i++)
                {
                    AddNodeToList(evens[i]);
                    Console.WriteLine(evens[i]);
                }
            }

            head = newHead;
            evens.Clear();
            odds.Clear();
            newHead = null;

            return head;
        }

        private static void SplitToOddsAndEvens(ListNode node, int index)
        {
            if (node == null)
                return;

            if (index % 2 == 0)
                evens.Add(node.val);
            else
                odds.Add(node.val);

            if (node.next != null)
                SplitToOddsAndEvens(node.next, index + 1);
        }

        private static void AddNodeToList(int val)
        {
            if (newHead == null)
            {
                newHead = new ListNode(val);
                newHead.next = null;
            }
            else
            {
                var nextNode = new ListNode(val);

                var current = newHead;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = nextNode;
            }
        }
    }
}