namespace DayOfTheProgrammer
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string s = dayOfProgrammer(1800);
            Console.WriteLine(s);
            Console.ReadLine();
        }

        static string dayOfProgrammer(int year)
        {
            int day = 0;
            int month = 0;
            int dayOfProgrammer = 256;
            bool isLapYear = year >= 1700 && year <= 1917 ?
                year % 4 == 0 :                                         //for julian calendar
                year % 400 == 0 || year % 4 == 0 && year % 100 != 0;    //for gregorian calendar
            int[] daysInMonth =
            {
                31,                     //January
                !isLapYear ? 28 : 29,   //February
                31,                     //March
                30,                     //April
                31,                     //May
                30,                     //June
                31,                     //July
                31,                     //August
                30,                     //September
                31,                     //October
                30,                     //November
                31                      //December
            };

            if (year == 1918) //February was 29 day and 14th February was 32nd day of year. 26.09.1918
            {
                day = 26;
                month = 9;
            }
            else
            {
                int sum = 0;
                int monthIndex = 0;
                for (int i = 0; i < daysInMonth.Length; i++)
                {
                    sum += daysInMonth[i];
                    if (sum >= dayOfProgrammer)
                    {
                        monthIndex = i;
                        break;
                    }
                }

                day = daysInMonth[monthIndex] - (sum - dayOfProgrammer);
                month = monthIndex + 1;
            }

            string result = month < 10 ? $"{day}.0{month}.{year}" : $"{day}.{month}.{year}";
            return result;
        }
    }
}
