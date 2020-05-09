using System;
using System.Collections.Generic;

namespace LeetCode.Main
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var res = 0; 
            var visited = new bool[256]; 
  
            for (int i = 0; i < s.Length; i++) 
            { 
                for (int j = i; j < s.Length; j++) 
                { 
                    if (visited[s[j]]) 
                        break;
                    
                    res = Math.Max(res, j - i + 1); 
                    visited[s[j]] = true;
                } 
                visited[s[i]] = false; 
            } 
            return res; 
        }
    }
}