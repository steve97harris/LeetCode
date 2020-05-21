using System;

namespace LeetCode.Main.Solutions
{
    public class PrintListNodes
    {
        public static void DisplayNodes(ListNode head)
        {
            if (head == null)
                return;
            
            Console.WriteLine(head.val);
            
            if (head.next != null)
                DisplayNodes(head.next);
        }
    }
}