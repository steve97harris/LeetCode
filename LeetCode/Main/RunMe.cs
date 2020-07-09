using System;
using System.Collections.Generic;
using LeetCode.Main.CodingTestYR;
using LeetCode.Main.DesignSolutions;
using LeetCode.Main.Solutions;
using LeetCode.Main.VersatileClasses;
using LeetCode.Main.VersatileClasses.TreesAndGraphs;

namespace LeetCode.Main
{
    namespace LeetCode.Main
    {
        public static class RunMe
        {
            private static void Main()
            {
                DecryptStringFromLettersToNumbers.FreqAlphabets("25#23#");
            }        

            #region CodeTests

            // int[] A = {10, 5, 7};
            // int[] P = {2, 3};
            // CodingTest.GetQueueTimeWithPrinters(A,P);

            #endregion

            #region VersatileClassesExamples

            // Array to Binary Tree:
            // var nums = new int[] {6, 7, 8, 2, 7, 1, 3, 9, -1, 1, 4, -1, -1, -1, 5};
            // var root = ArrayToBinaryTree.ArrayToBt(nums, new TreeNode(), 0);
            // root.Print();

            #endregion

            #region Incomplete

                // ZigZagConversion.Convert("PAYPALISHIRING", 4);

                // PartitionDeLabels.PartitionLabels("ababcbacadefegdehijhklij");

                // var root = new Node(1);
                // var rootChildren = root.children = new List<Node>();
                // rootChildren.Add(new Node(3));
                // rootChildren.Add(new Node(2));
                // rootChildren.Add(new Node(4));
                // var rootChildrenLevel2 = root.children[0].children = new List<Node>();
                // rootChildrenLevel2.Add(new Node(5));
                // rootChildrenLevel2.Add(new Node(6));
                // TreePreorderTraversal.Preorder(root);
                
                // var twitter = new Twitter();
                // twitter.PostTweet(1,4);            
                // twitter.PostTweet(2,5);           
                // twitter.Follow(1,2);
                // twitter.GetNewsFeed(1);
                // twitter.Unfollow(1,2);
                // twitter.GetNewsFeed(1);

                // SortCharsByFreq.FrequencySort("tree");
                
                // var dislikes = new int[][]
                // {
                //     new int[] {1, 2},
                //     new int[] {1, 3},
                //     new int[] {2, 4}
                // };
                // PossibleBiPartition.PossibleBipartition(4, dislikes);
                
                // const uint x = 4294967293;
                // ReverseDeBits.ReverseBits(x);
                
                // LongestPalindromicSubstring.LongestPalindrome("abababcd");
                
                // LetterCombinationsOfAPhoneNumber.LetterCombinations("23");
                
                // InvertBinaryTree.InvertTree(root);

                // var root = new TreeNode(1);
                // root.left = new TreeNode(2);
                // root.right = new TreeNode(3);
                // root.right.left = new TreeNode(4);
                // root.right.right = new TreeNode(5);
                // var s = "[1,2,3,null,null,4,5]";
                // var x = new EncodeDecodeBinaryTree();
                // x.Serialize(root);
                // x.Deserialize(s);

                #endregion
        }
    }
}