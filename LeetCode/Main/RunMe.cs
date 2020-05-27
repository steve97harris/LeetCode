﻿using System;
using System.Collections.Generic;
using LeetCode.Main.CodingTestYR;
using LeetCode.Main.DesignSolutions;
using LeetCode.Main.Solutions;
using LeetCode.Main.VersatileClasses;

namespace LeetCode.Main
{
    namespace LeetCode.Main
    {
        public static class RunMe
        {
            private static void Main()
            {
                // var root = new Node(1)
                // {
                //     children = new List<Node>()
                //     {
                //         new Node(3), new Node(2), new Node(4)
                //     }
                // };
                // root.children[0].children = new List<Node>() {new Node(5), new Node(6)};
                // TreePostorderTraversal.Postorder(root);

                const uint x = 4294967293;
                ReverseDeBits.ReverseBits(x);
            }        

            #region CodeTests

            // int[] A = {10, 5, 7};
            // int[] P = {2, 3};
            // CodingTest.GetQueueTimeWithPrinters(A,P);

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
                
                // ValidSudoku.IsValidSudoku(new char[][]
                // {
                //     new char[] {'1', '.', '3'},
                //     new char[] {'1', '2', '3'},
                //     new char[] {'1', '2', '3'}
                // });
                
                // SortCharsByFreq.FrequencySort("tree");
                
                // var dislikes = new int[][]
                // {
                //     new int[] {1, 2},
                //     new int[] {1, 3},
                //     new int[] {2, 4}
                // };
                // PossibleBiPartition.PossibleBipartition(4, dislikes);

                #endregion
        }
    }
}