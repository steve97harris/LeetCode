using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class AddAndSearchWordDataStructureDesign
    {
        private List<string> wordList;
        
        public AddAndSearchWordDataStructureDesign()
        {
            wordList = new List<string>();    
            
        }

        public void AddWord(string word)
        {
            wordList.Add(word);
        }

        public bool Search(string word)
        {
            if (wordList.Contains(word))
            {
                Console.WriteLine(word + " -> true");
                return true;
            }

            var charList = word.ToList();
            if (charList.Contains('.'))
            {
                charList.RemoveAll(c => c == '.');
                var searchWordWithoutDot = new string(charList.ToArray());

                var indexOfDots = new List<int>();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == '.')
                    {
                        indexOfDots.Add(i);
                    }
                }

                foreach (var item in wordList)
                {
                    if (!item.Contains(searchWordWithoutDot)) continue;
                    
                    var itemAsCharList = item.ToList();

                    if (indexOfDots.Count >= 2)
                    {
                        for (int i = 0; i < indexOfDots.Count; i++)
                        {
                            itemAsCharList.RemoveAt(indexOfDots[i] - i);
                        } 
                    }
                    else
                    {
                        itemAsCharList.RemoveAt(indexOfDots[0]);
                    }
                    
                    
                    var result = new string(itemAsCharList.ToArray());
                    if (result == searchWordWithoutDot)
                    {
                        Console.WriteLine(word + " -> true*");
                        return true;
                    }
                }
            }
            
                
            Console.WriteLine(word + " -> false");
            return false;
        }
    }
}