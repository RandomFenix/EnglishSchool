using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Entities
{
    public class Timetable
    {
        public DateTime dateTime = DateTime.Now;
        public int[,] daysInMonth = new int[5, 7];

        public int GetDay()
        {
            int countDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            return countDays;
        }
    }
}
