using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class PalindromeLinkedList
    {
        private static List<int> nodeVals = new List<int>();
        public static bool IsPalindrome(ListNode head)
        {
            AddNodesToList(head);

            var stringVals = string.Join("", nodeVals);

            var rev = nodeVals;
            rev.Reverse();

            var revStringVals = string.Join("", rev);

            return stringVals == revStringVals;
        }

        private static void AddNodesToList(ListNode node)
        {
            if (node == null)
                return;

            nodeVals.Add(node.val);

            if (node.next != null)
                AddNodesToList(node.next);
        }
    }
}