using System;
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
                var twitter = new Twitter();
                twitter.PostTweet(1,5);            // user 1 posts tweetID 5
                // twitter.GetNewsFeed(1);                   // returns tweetID 5
                twitter.Follow(1,2);          // 1 follows 2
                twitter.PostTweet(2,6);           // user 2 posts tweetID 6 
                twitter.GetNewsFeed(1);                  // user 1 should return tweetID's 6,5
                // twitter.Unfollow(1,2);       // user 1 unfollows user 2
                // twitter.GetNewsFeed(1);                 // returns tweetID 5
                // twitter.DisplayAllUserNewsFeeds();
            }        

            #region CodeTests

            // int[] A = {10, 5, 7};
            // int[] P = {2, 3};
            // CodingTest.GetQueueTimeWithPrinters(A,P);

            #endregion

            #region Incomplete
            
                // string[] strings = { "36","28","70","65","C","+","33","-46","84","C" };
                // BaseballGame.CalPoints(strings);

                // TreeNode root = new TreeNode(7);
                // root.left = new TreeNode(4);
                // root.right = new TreeNode(3);
                // root.right.left = new TreeNode(6);
                // root.right.right = new TreeNode(19);
                // TreeNode clone = root;
                // TreeNode target = root.right;        // Val = 3
                // CorrespondingNodeOfBinaryTreeInACloneOfThatTree.GetTargetCopy(root, clone, target);

                // Time Limit Exceeded:
                // AddAndSearchWordDataStructureDesign wordDictionary = new AddAndSearchWordDataStructureDesign();
                // wordDictionary.AddWord("a");
                // wordDictionary.AddWord("ab");
                // wordDictionary.Search("a.");
                
                // ZigZagConversion.Convert("PAYPALISHIRING", 4);
                
                // var root = new TreeNode(7)
                // {
                //     left = new TreeNode(3),
                //     right = new TreeNode(15) 
                //     {
                //         left = new TreeNode(9), 
                //         right = new TreeNode(20)
                //     }
                // };
                // var iterator = new BinarySearchTreeIterator(root);
                // iterator.Next();    // return 3
                // iterator.Next();    // return 7
                // iterator.HasNext(); // return true
                // iterator.Next();    // return 9
                // iterator.HasNext(); // return true
                // iterator.Next();    // return 15
                // iterator.HasNext(); // return true
                // iterator.Next();    // return 20
                // iterator.HasNext();
                
                // PartitionDeLabels.PartitionLabels("ababcbacadefegdehijhklij");

              
                
                #endregion
        }
    }
}