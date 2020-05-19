using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class DeleteDeNode
    {
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

        public static void DisplayNodes(ListNode head)
        {
            if (head == null)
                return;
            
            Console.WriteLine(head.val);
            
            if (head.next != null)
                DisplayNodes(head.next);
        }
    }
}