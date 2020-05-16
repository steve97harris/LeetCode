using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class OddEvenLinkedList
    {
        private static List<ListNode> evens = new List<ListNode>();        // position in linked list, NOT value
        private static List<ListNode> odds = new List<ListNode>();
        public static ListNode OddEvenList(ListNode head)
        {
            SplitToOddsAndEvens(head, 1);
            var newHead = new ListNode(odds[0].val);
            
            
            return head;
        }

        private static void SplitToOddsAndEvens(ListNode node, int index)
        {
            if (node == null)
                return;
            
            if (index % 2 == 0)
                evens.Add(node);
            else
                odds.Add(node);
            
            if (node.next != null)
                SplitToOddsAndEvens(node.next, index + 1);
        }

        private static void AddNodeToList(ListNode head)
        {
            
        }
    }
}