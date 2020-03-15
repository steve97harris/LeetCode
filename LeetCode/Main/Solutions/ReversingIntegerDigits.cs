using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class ReversingIntegerDigits
    {
        public static int ReverseInt(int x)
        {
            string xString = x.ToString();
            List<char> intList = new List<char>();
            List<char> reverseList = new List<char>();

            foreach (char character in xString)
            {
                intList.Add(character);
            }

            List<char> leftSide = new List<char>();
            List<char> rightSide = new List<char>();
            
            int midPoint = intList.Count / 2;
            for (int i = 0; i < midPoint; i++)
            {
                leftSide.Add(intList[i]);
            }
            for (int i = 0; i > midPoint; i++)
            {
                rightSide.Add(intList[i]);
            }

            foreach (char c in rightSide)
            {
                reverseList.Add(c);
            }
            foreach (char c in leftSide)
            {
                reverseList.Add(c);
            }

            reverseList.ToString();
            
            // Append() ??

            return x;
        }
    }
}