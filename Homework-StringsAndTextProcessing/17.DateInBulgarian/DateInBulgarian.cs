using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Write a program that reads a date and time given in the format: 
//day.month.year hour:minute:second and prints the date and time 
//after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
namespace _17.DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
            //Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("bg-BG");
            string httpTime = "27 Feb 2012 03:11:21";
            DateTime timeAfterSixHouers = DateTime.Parse(httpTime).AddHours(6).AddMinutes(30);
            var culture = new System.Globalization.CultureInfo("bg-BG");
            string day = culture.DateTimeFormat.GetDayName(DateTime.Parse(httpTime).DayOfWeek);          
            Console.WriteLine("{0}",timeAfterSixHouers.DayOfWeek);
            Console.WriteLine(timeAfterSixHouers);
            Console.WriteLine(day);                      
        }
    }
}
