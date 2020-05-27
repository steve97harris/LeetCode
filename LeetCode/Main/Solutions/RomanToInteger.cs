using System;

namespace LeetCode.Main.Solutions
{
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        if (i < s.Length - 1)
                        {
                            switch (s[i + 1])
                            {
                                case 'V':
                                    count += 4;
                                    i++; 
                                    continue;
                                case 'X':
                                    count += 9;
                                    i++;
                                    continue;
                            }
                        }
                        count += 1;
                        break;
                    case 'V':
                        count += 5;
                        break;
                    case 'X':
                        if (i < s.Length - 1)
                        {
                            switch (s[i + 1])
                            {
                                case 'L':
                                    count += 40;
                                    i++; 
                                    continue;
                                case 'C':
                                    count += 90;
                                    i++;
                                    continue;
                            }
                        }
                        count += 10;
                        break;
                    case 'L':
                        count += 50;
                        break;
                    case 'C':
                        if (i < s.Length - 1)
                        {
                            switch (s[i + 1])
                            {
                                case 'D':
                                    count += 400;
                                    i++; 
                                    continue;
                                case 'M':
                                    count += 900;
                                    i++;
                                    continue;
                            }
                        }
                        count += 100;
                        break;
                    case 'D':
                        count += 500;
                        break;
                    case 'M':
                        count += 1000;
                        break;
                }
            }

            Console.WriteLine(count);
            return count;
        }
    }
}