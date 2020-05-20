using System;

namespace LeetCode.Main
{
    public static class RemoveNthNodeFromEndOfLinkedList
    {
        private static int count;
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            GetLinkedListLength(head);

            var diff = count - n;
            if (n > count)
                return head;
            if (n == count)
                return head.next;
            
            
            ListNode prev = null;
            var curr = head;
            for (int i = 0; i < diff; i++)
            {
                prev = curr;
                curr = curr.next;
            }

            if (prev != null) 
                prev.next = curr.next;

            DisplayNodes(head);
            return head;
        }

        private static void GetLinkedListLength(ListNode node)
        {
            var temp = node;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
        }

        private static void DisplayNodes(ListNode head)
        {
            if (head == null)
                return;
            
            Console.WriteLine(head.val);
            
            if (head.next != null)
                DisplayNodes(head.next);
        }
    }
}