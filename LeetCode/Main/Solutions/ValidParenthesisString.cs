using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class ValidParenthesisString
    {
        public static bool CheckValidString(string s)
        {
            if (s == null)
                return true;

            var left = 0;
            var needRight = 0;
            var special = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        left++;
                        needRight++;
                        break;
                    case ')':
                        if (left > 0)
                        {
                            left--;
                            if (needRight > 0)
                                needRight--;
                        }
                        else if (special > 0)
                            special--;
                        else
                            return false;
                        break;
                    case '*':
                        special++;
                        if (needRight > 0)
                            needRight--;
                        break;
                }
            }
            
            return needRight == 0 ? true : false; 
            // return true if bracket count is 0, else return false 
        }
    }
}