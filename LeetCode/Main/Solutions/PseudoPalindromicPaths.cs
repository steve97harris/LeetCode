using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class PseudoPalindromicPathsI
    {
        private List<List<int>> paths = new List<List<int>>();
        private List<int[]> rearrangements = new List<int[]>();
        public int PseudoPalindromicPaths(TreeNode root)
        {
            var palindromeCount = 0;
            var path = new int[1000];
            Recursion(root, path, 0);

            for (int i = 0; i < paths.Count; i++)
            {
                GetPer(paths[i].ToArray());
            }

            for (int i = 0; i < rearrangements.Count; i++)
            {
                for (int j = 0; j < rearrangements[i].Length; j++)
                {
                    Console.WriteLine(rearrangements[i][j]);
                }
                Console.WriteLine("---");
                var isPalindromic = CheckIfPalindromic(rearrangements[i]);
                if (isPalindromic)
                {
                    palindromeCount++;
                }
            }

            Console.WriteLine(palindromeCount);
            return palindromeCount;
        }

        private void Recursion(TreeNode node, int[] path, int index)
        {
            if (node == null)
                return;
            
            path[index] = node.val;
            index++;
            
            if (node.left == null && node.right == null)
            {
                var tempPath = new List<int>();
                for (int i = 0; i < index; i++)
                {
                    tempPath.Add(path[i]);
                }
                paths.Add(tempPath);
            }
            else
            {
                Recursion(node.left, path, index);
                Recursion(node.right, path, index);
            }
        }
        
        private void Swap(ref int a, ref int b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }

        private void GetPer(int[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private void GetPer(int[] list, int k, int m)
        {
            if (k == m)
            {
                var temp = new int[list.Length];
                for (int i = 0; i < list.Length; i++)
                {
                    temp[i] = list[i];
                }
                if (!IsDuplicate(temp))
                    rearrangements.Add(temp);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        private bool IsDuplicate(int[] arr)
        {
            if (rearrangements.Count == 0)
                return false;
            
            for (int i = 0; i < rearrangements.Count; i++)
            {
                if (rearrangements[i].SequenceEqual(arr))
                    return true;
            }

            return false;
        }

        private bool CheckIfPalindromic(int[] arr)        
        {
            var rev = arr.Reverse().ToArray();
            return arr.SequenceEqual(rev);
            
            // or Note that the node values of a path form a palindrome if at most one digit has an odd frequency (parity).
        }
    }
}