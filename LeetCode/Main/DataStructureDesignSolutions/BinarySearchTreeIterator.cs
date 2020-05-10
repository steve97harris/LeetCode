using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public class BinarySearchTreeIterator
    {
        private TreeNode mRoot;
        private int mNext = 0;
        private int mCurrentSmallest;
        private int mLargestNodeValue;
        private List<int> mListOfSmallest = new List<int>();
        public BinarySearchTreeIterator(TreeNode root)
        {
            if (root == null) return;
            mRoot = root;
            mCurrentSmallest = root.val;
            mLargestNodeValue = 1;
        }

        public int Next()        // returns next smallest number in tree
        {
            mNext = NextHelper(mRoot);
            mListOfSmallest.Add(mNext);
            mCurrentSmallest = mLargestNodeValue;
            
            Console.WriteLine("return " + mNext);
            return mNext;
        }

        public bool HasNext()        // returns whether next smallest number exists
        {
            Console.WriteLine(mNext != mLargestNodeValue);
            return mNext != mLargestNodeValue;
        }

        private int NextHelper(TreeNode root)
        {
            if (root == null)
                return -1;

            if (root.val < mCurrentSmallest && !mListOfSmallest.Contains(root.val))
            {
                mCurrentSmallest = root.val;
            }
            
            if (root.left != null)
                NextHelper(root.left);
            if (root.right != null)
                NextHelper(root.right);

            if (root.val > mLargestNodeValue)
                mLargestNodeValue = root.val;
            
            return mCurrentSmallest;
        }
    }
    
    /// <summary>
    /// Correct answer below: 
    /// </summary>
    public class BSTIterator
    {
        private Stack<TreeNode> stack = null;

        public BSTIterator(TreeNode root)
        {
            stack = new Stack<TreeNode>();
            TreeNode temp = root;
            while (temp != null)
            {
                stack.Push(root);
                temp = temp.left;
            }
        }

        public bool HasNext()
        {
            return (stack.Count == 0);
        }

        public int Next()
        {
            if (stack.Count == 0)
            {
                return Int32.MaxValue;
            }

            // pop a node
            TreeNode popped = stack.Pop();

            // init stack with right node
            TreeNode temp = popped.right;
            while (temp != null)
            {
                stack.Push(temp);
                temp = temp.left;
            }

            return popped.val;
        }
    }
}