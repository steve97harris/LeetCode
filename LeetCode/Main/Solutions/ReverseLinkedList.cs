
using System.Collections.Generic;

namespace LeetCode.Main
{
    public class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode previous = head;
            ListNode n = null;
            while (head != null)
            {
                ListNode temp = previous.next;
                previous.next = n;
                n = previous;
                previous = temp;
            }

            head = n;
            
            return previous;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}