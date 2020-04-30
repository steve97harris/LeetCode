using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class DeleteNodeInLinkedList
    {
        public static void DeleteNode(ListNode node)
        {
            if (node == null) return;
            node.val = node.next.val;
            DeleteNode(node.next);
        }
    }
}