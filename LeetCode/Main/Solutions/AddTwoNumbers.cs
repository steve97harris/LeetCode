using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class Add2Numbers
    {
        private static ListNode head;
        private static List<int> nodeValuesList = new List<int>();
        private static List<int> resultList = new List<int>();
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var num1 = ConvertNodesToNumberAndReverse(l1);
            var num2 = ConvertNodesToNumberAndReverse(l2);
            var sumOfNodeNums = num1 + num2;
            Console.WriteLine(sumOfNodeNums);

            var temp = sumOfNodeNums.ToString().Reverse().ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                resultList.Add(int.Parse(temp[i].ToString()));
            }
            
            head = new ListNode(resultList[0]);
            for (int i = 1; i < resultList.Count; i++)
            {
                AddLast(resultList[i]);
            }

            return head;
        }
        
        private static void AddLast(int val)
        {
            if (head == null)
            {
                head = new ListNode(val);
                head.next = null;
            }
            else
            {
                var toAdd = new ListNode(val);

                var current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        private static int ConvertNodesToNumberAndReverse(ListNode root)
        {
            GetNodes(root);
            nodeValuesList.Reverse();
            var str = string.Join("", nodeValuesList);
            var num = int.Parse(str);
            Console.WriteLine(num);
            nodeValuesList.Clear();
            return num;
        }
        
        private static void GetNodes(ListNode node)
        {
            if (node != null)
                nodeValuesList.Add(node.val);
            if (node?.next != null)
                GetNodes(node.next);
        }
    }
}