using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class MergeTwoSortedLists
    {
        private static ListNode newHead;
        private static List<int> allNodeValues = new List<int>();
        public static ListNode MegerTwoLists(ListNode l1, ListNode l2)
        {
            AddNodesToList(l1);
            AddNodesToList(l2);
            
            allNodeValues.Sort();

            for (int i = 0; i < allNodeValues.Count; i++)
            {
                AddToLinkedList(allNodeValues[i]);
            }

            PrintListNodes.DisplayNodes(newHead);
            
            return newHead;
        }

        private static void AddNodesToList(ListNode node)
        {
            if (node == null)
                return;
            
            allNodeValues.Add(node.val);
            if (node.next != null)
                AddNodesToList(node.next);
        }

        private static void AddToLinkedList(int val)
        {
            if (newHead == null)
            {
                newHead = new ListNode(val);
                newHead.next = null;
            }
            else
            {
                var curr = newHead;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = new ListNode(val);
            }
        }
    }
}