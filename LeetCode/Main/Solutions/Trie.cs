using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LeetCode.Main
{
    public class TrieNode
    {
        public bool isEnd = false;                                // stores whether the current character is the end of a word
        public TrieNode[] children = new TrieNode[26];            // array of size 26 that stores the nodes children

        public TrieNode()
        {
            
        }
    }
    public class Trie
    {
        private TrieNode root;
        
        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode current = root;

            foreach (var character in word)
            {
                var charIndex = character - 'a';        // returns index of each character with respect to the alphabet!!
                Console.WriteLine("id = " + charIndex);

                if (current.children[charIndex] == null)
                {
                    current.children[charIndex] = new TrieNode();
                }

                current = current.children[charIndex];        // setting current Node children as charIndex values of word!
            }

            current.isEnd = true;        // setting end of word to true! 
        }

        public bool Search(string word)
        {
            TrieNode node = SearchNode(word);
            
            if (node != null && node.isEnd)        // check last characterIndex is true. 
                return true;
            
            return false;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode node = SearchNode(prefix);
            
            return node != null;
        }
        
        private TrieNode SearchNode(string word)
        {
            TrieNode current = root;

            int i = 0;
            while (i < word.Length)
            {
                var charIndex = word[i++] - 'a';
                current = current.children[charIndex];        // set current node children to charIndex of searched word
                Console.WriteLine(charIndex);
                if (current == null)
                    return null;
            }
            
            return current;
        }
    }
}