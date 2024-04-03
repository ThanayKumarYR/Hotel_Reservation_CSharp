using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class DaysCalculator
    {
        public (int, int) Count()
        {
            int weekEndCount = 0, weekDayCount = 0;
            string format = "ddMMMyyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            Console.WriteLine("Reservation Dates");
            Console.Write("Enter the strating date in ddMMMyyyy format = ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), format, provider);
            Console.Write("Enter the ending date in ddMMMyyyy format = ");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), format, provider);
            if (start > end)
            {
                return (-1, -1);
            }
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    weekEndCount++;
                }
                else
                {
                    weekDayCount++;
                }
            }
            return (weekDayCount, weekEndCount);
        }
    }
}
