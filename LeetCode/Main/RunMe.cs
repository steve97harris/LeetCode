﻿using System;
using System.Collections.Generic;
using LeetCode.Main.CodingTestYR;
using LeetCode.Main.DesignSolutions;
using LeetCode.Main.Solutions;

namespace LeetCode.Main
{
    namespace LeetCode.Main
    {
        public static class RunMe
        {
            static void Main()
            {
                var s = new StockSpanner();
                // s.Next(100);
                // s.Next(80);
                // s.Next(60);
                // s.Next(70);
                // s.Next(60);
                // s.Next(75);
                // s.Next(85);
               
                s.Next(31);
                s.Next(41);
                s.Next(48);
                s.Next(59);
                s.Next(79); 
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
                
                #endregion
        }
    }
}