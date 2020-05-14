using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class ConvertBinaryNumberInLinkedListToInt
    {
        private static string num = "";
        public static int GetDecimalValue(ListNode head)
        {
            GetNum(head);
            return Convert.ToInt32(num, 2);
        }

        private static void GetNum(ListNode head)
        {
            if (head == null) return;
            num += head.val;
            GetNum(head.next);
        }
    }
}