using System;
using System.Linq;

namespace LeetCode.Main
{
    public static class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            bool isHappy = false;
            string nString = n.ToString();
            int ans = 0;

            int[] nArray = new int[nString.Length];

            for (int i = 0; i < nString.Length; i++)
            {
                nArray[i] = Int32.Parse(nString[i].ToString());
                Console.WriteLine(nArray[i]);
            }

            for (int i = 0; i < nArray.Length - 1; i++)
            {
                ans = (int) (Math.Pow(nArray[i], 2) + Math.Pow(nArray[i+1], 2));
                Console.WriteLine("Answer: " + ans);
                
                
                if (ans == 1)
                {
                    isHappy = true;
                    break;
                }

                IsHappy(ans);
            }
            
            Console.WriteLine(isHappy);
            return isHappy;
        }
    }
}