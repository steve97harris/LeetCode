using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public static class DayOfTheWeek
    {
        public static string DayOfWeek(int day, int month, int year)
        {
            var yy = year % 100;        // divide by 100, give out remainder. 
            var yyBy4 = yy / 4;
            var x = yyBy4 + yy;
            var yearCode = x % 7;
            Console.WriteLine("YearCode: " + yearCode);
            
            Dictionary<string, int> monthDictionary = new Dictionary<string, int>();
            string[] months = new string[12];
            int[] monthCodes = {0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5};
            for (int i = 0; i < months.Length; i++)
            {
                monthDictionary.Add((i+1).ToString(),monthCodes[i]);
            }

            int monthCode = 0;
            foreach (var pair in monthDictionary)
            {
                if (month.ToString() == pair.Key)
                {
                    monthCode = pair.Value;
                }
            }
            Console.WriteLine("MonthCode: " + monthCode);

            var YY = year / 100;
            Dictionary<int,int> centuryDictionary = new Dictionary<int, int>();
            int[] centuries = {17, 18, 19, 20, 21, 22, 23};
            int[] centuryCodes = {4, 2, 0, 6, 4, 2, 0};
            for (int i = 0; i < centuries.Length; i++)
            {
                centuryDictionary.Add(centuries[i],centuryCodes[i]);
            }

            int centuryCode = 0;
            foreach (var pair in centuryDictionary)
            {
                if (YY == pair.Key)
                {
                    centuryCode = pair.Value;
                }
            }
            Console.WriteLine("CenturyCode: " + centuryCode);

            int leapYearCode = 0;
            if (year % 4 == 0 && (month == 1 || month == 2))
            {
                leapYearCode = 1;
            }
            Console.WriteLine("LeapYearCode: " + leapYearCode);

            int dayOfTheWeek = (yearCode + monthCode + centuryCode + day - leapYearCode) % 7;
            Dictionary<int,string> dayOfWeekDictionary = new Dictionary<int, string>();
            string[] days = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            for (int i = 0; i < 7; i++)
            {
                dayOfWeekDictionary.Add(i,days[i]);
            }

            string result = "";
            foreach (var pair in dayOfWeekDictionary)
            {
                if (dayOfTheWeek == pair.Key)
                {
                    result = pair.Value;
                }
            }
            Console.WriteLine("Result: " + result);
            
            return result;
        }
    }
}