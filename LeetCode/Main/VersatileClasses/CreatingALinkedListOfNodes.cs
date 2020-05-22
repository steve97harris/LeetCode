using System.Collections.Generic;

namespace LeetCode.Main.VersatileClasses
{
    public static class CreatingALinkedListOfNodes
    {
        private static ListNode newHead;
        private static List<int> nodeValues = new List<int>();

        public static ListNode Example()
        {
            nodeValues.Add(1);
            nodeValues.Add(2);
            nodeValues.Add(3);
            
            for (int i = 0; i < nodeValues.Count; i++)
            {
                AddToLinkedList(nodeValues[i]);
            }

            return newHead;
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