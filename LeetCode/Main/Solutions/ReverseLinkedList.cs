
using System;
using System.Collections.Generic;
using LeetCode.Main.Solutions;

namespace LeetCode.Main
{
    public class ReverseLinkedList
    {
        private static ListNode newHead;
        private static List<ListNode> nodes = new List<ListNode>();
        public static ListNode ReverseList(ListNode head)
        {
            GetNods(head);
            nodes.Reverse();

            for (int i = 0; i < nodes.Count; i++)
            {
                AddNodeToLinkedList(nodes[i].val);
            }
            
            PrintListNodes.DisplayNodes(newHead);

            return head;
        }

        private static void AddNodeToLinkedList(int newNodeVal)
        {
            if (newHead == null)
            {
                newHead = new ListNode(newNodeVal) {next = null};
            }
            else
            {
                var nextNode = new ListNode(newNodeVal);

                var current = newHead;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = nextNode;
            }
        }

        private static void GetNods(ListNode node)
        {
            while (true)
            {
                if (node == null) 
                    return;

                nodes.Add(node);

                if (node.next != null)
                {
                    node = node.next;
                    continue;
                }

                break;
            }
        }
    }
}