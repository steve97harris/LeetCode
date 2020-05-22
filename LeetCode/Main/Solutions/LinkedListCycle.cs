using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class LinkedListCycle
    {
        private static List<int> nodes = new List<int>();
        public static bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            if (nodes.Contains(head.next.val))
                return true;
            nodes.Add(head.val);

            if (head.next != null)
            {
                HasCycle(head.next);
            }

            return false;
        }
    }
}