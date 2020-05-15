using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class CharNode
    {
        public bool isEnd = false;        // is end of word
        public CharNode[] children = new CharNode[27];

        public CharNode()
        {
            
        }
    }
    public class AddAndSearchWordDataStructureDesign
    {
        private CharNode root;
        
        public AddAndSearchWordDataStructureDesign()
        {
            root = new CharNode();
        }

        public void AddWord(string word)
        {
            var node = root;
            foreach (var c in word)
            {               
                int index = c - 'a';
                if (c == '.')
                {
                    index = 26; // last one is reserved for '.' character
                }

                if (node.children[index] == null)
                {
                    node.children[index] = new CharNode();
                }

                node = node.children[index];                
            }

            // last one is set as leaf node
            node.isEnd = true;
        }

        public bool Search(string word)
        {
            return SearchNode(word, root);
        }

        private bool SearchNode(string word, CharNode node)
        {
            for (int i = 0; i < word.Length; i++)
            {
                var current = word[i];
                var charIndex = word[i] - 'a';
                var isDot = current == '.';
                
                if (!isDot)
                {
                    if (node.children[charIndex] == null)
                        return false;

                    node = node.children[charIndex];
                }
                else
                {
                    if (i == word.Length - 1)
                    {
                        return node.children.Any(child => child != null && child.isEnd);
                    }

                    var restOfWord = word.Substring(i + 1);    // skip dot

                    return node.children.Where(child => child != null).Any(child => SearchNode(restOfWord, child));
                }
            }

            return node.isEnd;
        }
    }
}