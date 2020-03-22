using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LeetCode.Main
{
    public static class TreePostorderTraversal
    {
        public static IList<int> Postorder(Node root)
        {
            IList<int> slkdf = new Collection<int>();
            for (int i = 0; i < root.children.Count; i++)
            {
                
            }

            return slkdf;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
}