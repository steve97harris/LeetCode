using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class IntersectionOfTwoLinkedLists
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            return headA;
        }

        private static void GetNodeValues(ListNode head1, ListNode currHead2)
        {
            if (head1 == null)
                return;
            
            
            if (head1.next != null)
                GetNodeValues(head1.next, currHead2);
        }
    }
}