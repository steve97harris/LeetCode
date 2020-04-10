using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class MinimumElementInStack
    {
        public static List<List<int>> list = new List<List<int>>();
        
        static MinimumElementInStack()
        {
            
        }

        public static void Push(int x)        // insert object at top of stack
        {
            if (list.Count == 0 || list[list.Count - 1][0] > x)
                list.Add(new List<int>() {x, x});
            else
            {
                list.Add(new List<int>() {list[list.Count - 1][0], x});
            }
        }

        public static void Pop()        // removes and returns the object at the top of the stack
        {
            list.RemoveAt(list.Count - 1);        // index: [list.count - 1] is the list at the top of stack 
        }

        public static int Top()
        {
            return list[list.Count - 1][1];        
        }

        public static int GetMin()
        {
            return list[list.Count - 1][0];
        }
    }
}