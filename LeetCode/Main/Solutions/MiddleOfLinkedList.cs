using System;

namespace LeetCode.Main.Solutions
{
    public static class MiddleOfLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            if (head == null)
                return null;

            var listLength = GetLength(head);
            if (listLength == 0)
                return null;

            int index = 0;
            ListNode middle = null;

            while (index <= listLength / 2)
            {
                middle = head;
                head = head.next;
                index++;
            }

            Console.WriteLine(middle);
            return middle;
        }

        public static int GetLength(ListNode head)
        {
            int length = 0;

            while (head != null)
            {
                length++;
                head = head.next;
            }

            return length;
        }
    }
}