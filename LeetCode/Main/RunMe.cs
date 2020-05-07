using System;
using System.Collections.Generic;
using LeetCode.Main.CodingTestYR;
using LeetCode.Main.Solutions;

namespace LeetCode.Main
{
    namespace LeetCode.Main
    {
        public static class RunMe
        {
            static void Main()
            {
                // RevealCardsInIncreasingOrder.DeckRevealedIncreasing(new int[] {17, 13, 11, 2, 3, 5, 7});

                var root = new TreeNode(1)
                {
                    left = new TreeNode(2), 
                    right = new TreeNode(3)
                };
                root.left.left = new TreeNode(4);
                
                var x = 4;
                var y = 3;
                CousinsInBinaryTree.IsCousins(root, x, y);
            }

            #region CodeTests

            // int[] A = {10, 5, 7};
            // int[] P = {2, 3};
            // CodingTest.GetQueueTimeWithPrinters(A,P);

            #endregion

            #region Incomplete
            
                // string s = "loveleetcode";
                // char c = 'e';
                // ShortestDistanceToACharacter.ShortestToChar(s, c);

                // string[] words = {"Hello", "Alaska", "Dad", "Peace"};
                // KeyboardRow.KeyWords(words);

                // string[] strings = { "5","-2","4","C","D","9","+","+" };
                // BaseballGame.CalPoints(strings); 

                // int[] nums1 = { 4,1,2 };
                // int[] nums2 = { 1,3,4,2 };
                // NextGreaterElementI.NextGreaterElement(nums1, nums2);

                // string A =
                //         "mrbr laxcfv sibua csf ytk ul lefjh kn val w val qzlkqf slgpcfx oicqcq laxcfv w ul spo kpxq oyaspyt lefjh ubi w rtstn mrbr klhblwv f oyaspyt lefjh hqwijm lzz dx xfy spo hqwijm dx lefjh laxcfv val w",
                //     B =
                //         "luiesmz e hqwijm mrbr rtstn dkjlxto ytk f p cokfad ytk vdze oyaspyt klhblwv pznznkh ubi dkjlxto spo slgpcfx rwovl ubi wfax iieyr ws qmu re f lzz hqwijm j w kivo cyxnutx dkjlxto csf orjdywl mrbr w e";
                // UncommonWordsInSentences.UncommonWords(A, B);

                // var root = new TreeNode(3);
                // root.left = new TreeNode(9);
                // root.right = new TreeNode(20);
                // root.right.left = new TreeNode(15);
                // root.right.right = new TreeNode(7);
                // AverageLevelsInBinaryTree.AverageOfLevels(root);
                
                // TreeNode root = new TreeNode(7);
                // root.left = new TreeNode(4);
                // root.right = new TreeNode(3);
                // root.right.left = new TreeNode(6);
                // root.right.right = new TreeNode(19);
                // TreeNode clone = root;
                // TreeNode target = root.right;        // Val = 3
                // CorrespondingNodeOfBinaryTreeInACloneOfThatTree.GetTargetCopy(root, clone, target);

                // int candies = 60;
                // int peeps = 4;
                // DistributeCandiesToPeople.DistributeDeCandies(candies, peeps);

                // Time Limit Exceeded:
                // AddAndSearchWordDataStructureDesign wordDictionary = new AddAndSearchWordDataStructureDesign();
                // wordDictionary.AddWord("a");
                // wordDictionary.AddWord("ab");
                // wordDictionary.Search("a.");
                
                #endregion
        }
    }
}