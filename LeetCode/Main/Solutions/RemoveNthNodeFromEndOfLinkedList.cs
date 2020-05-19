using System;

namespace LeetCode.Main
{
    public static class RemoveNthNodeFromEndOfLinkedList
    {
        private static int indexOfN = -1;
        private static ListNode removeThisNode;
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            GetIndexOfNodes(head,n,0);

            if (head == removeThisNode)
            {
                head.val = head.next.val;
                head.next = head.next.next;
            }

            Console.WriteLine(removeThisNode.val);
            
            DisplayNodes(head);
            return head;
        }

        private static void GetIndexOfNodes(ListNode node,int n, int index)
        {
            if (node.next == null)
            {
                indexOfN = index - n;
            }

            if (index == indexOfN)
                removeThisNode = node;

            if (node.next != null)
                GetIndexOfNodes(node.next, n, index + 1);
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