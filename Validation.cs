using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotelReservation
{
    class Validation
    {
        public string Pattern { get; set; } = "^((0[1-9]|[1-2][0-9]|3[01])(Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)[0-9]{4})$";

        public bool Check(string date)
        { 
            Regex regex = new Regex(Pattern);
            return regex.IsMatch(date); 
        }
    }
}
