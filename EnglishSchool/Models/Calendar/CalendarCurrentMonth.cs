using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Models.Calendar
{
    public class CalendarCurrentMonth
    {
        public static DateTime dateTime = DateTime.Now;
        public static DateTime dateTimeFirstDay = new DateTime(dateTime.Year, dateTime.Month, 1);
        static int dateTimeFirstDayofWeek = (int)(dateTimeFirstDay.DayOfWeek) == 0 ? dateTimeFirstDayofWeek = 7 : (int)(dateTimeFirstDay.DayOfWeek);
        static int daysinPrevMonth = DateTime.DaysInMonth(dateTime.Year, dateTime.Month - 1);
        static int lastDayofMonth = (int)(dateTime.DayOfWeek) == 0 ? lastDayofMonth = 7 : (int)(dateTime.DayOfWeek);
        static string[] months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        static string[] daysMonths = new string[DateTime.DaysInMonth(dateTime.Year, dateTime.Month)];



        static int prevDays = dateTimeFirstDayofWeek - 1;
        static string[] prevMonthDays = new string[prevDays];
        static int nextDays = lastDayofMonth - 1;
        static string[] nextMonthsDays = new string[nextDays];

        static string[] allDays = new string[42];

        public static int getDate = dateTime.Day;

        public static string getMonth = months[dateTime.Month - 1];

        public static string[] GetPrevDays()
        {
            int j = 0;
            for (int i = daysinPrevMonth; j < prevMonthDays.Length; i--)
            {
                prevMonthDays[j] = i.ToString();
                j++;
            }
            for (var i = 0; i < prevMonthDays.Length / 2; i++)
            {
                (prevMonthDays[i], prevMonthDays[prevMonthDays.Length - (i + 1)]) = (prevMonthDays[prevMonthDays.Length - (i + 1)], prevMonthDays[i]);
            }
            return prevMonthDays;
        }
        public static string[] GetDays()
        {
            for (int i = 0; i < daysMonths.Length; i++)
            {
                daysMonths[i] = (i + 1).ToString();
            }
            return daysMonths;
        }

        public static string[] GetNextDays()
        {
            for (int i = 1; i <= nextMonthsDays.Length; i++)
            {
                nextMonthsDays[i - 1] = i.ToString();
            }
            return nextMonthsDays;
        }
    }
}
