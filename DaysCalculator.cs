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
            try
            {
                Validation validation = new Validation();

                int weekEndCount = 0, weekDayCount = 0;
                string format = "ddMMMyyyy";
                CultureInfo provider = CultureInfo.InvariantCulture;
                Console.WriteLine("Reservation Dates");
                Console.Write("Enter the strating date in ddMmmyyyy format = ");
                string strStart = Console.ReadLine();
                if (!validation.Check(strStart)) throw new ApplicationException("Start date is not in correct format !");
                DateTime start = DateTime.ParseExact(strStart, format, provider);
                Console.Write("Enter the ending date in ddMmmyyyy format = ");
                string strEnd = Console.ReadLine();
                if (!validation.Check(strStart)) throw new ApplicationException("End date is not in correct format !");
                DateTime end = DateTime.ParseExact(strEnd, format, provider);
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
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return (-1, -1);
            }
            
        }
    }
}
