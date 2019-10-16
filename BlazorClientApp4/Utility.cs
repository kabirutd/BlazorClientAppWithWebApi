using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientApp4
{
    public class Utility
    {

        public static DateTime GetFirstDayOfWeek(DateTime dateToCheck, string firstDay)
        {
            DateTime dt = new DateTime();
            for (int k = 0; k < 7; k++)
            {
                if (dateToCheck.AddDays(-k).DayOfWeek.ToString() == firstDay)
                {
                    dt = dateToCheck.AddDays(-k);
                }
            }
            return dt;
        }

        public static DateTime GetLastDayOfWeek(DateTime dateToCheck, string firstDay)
        {
            DateTime dt = new DateTime();
            for (int k = 0; k < 7; k++)
            {
                if (dateToCheck.AddDays(k).DayOfWeek.ToString() == firstDay)
                {
                    dt = dateToCheck.AddDays(k);
                }
            }
            return dt;
        }
    }
}
