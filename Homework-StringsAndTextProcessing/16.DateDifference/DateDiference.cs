using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads two dates in the format: 
//day.month.year and calculates the number of days between them.
namespace _16.DateDifference
{
    class DateDiference
    {
        static void Main()
        {
            Console.Write("Enter first date in format \"Day.Mont.Year\" : ");
            string textFirst = Console.ReadLine();
            Console.Write("Enter second date in format \"Day.Mont.Year\" : ");
            string textSecond = Console.ReadLine();
            string format = "dd.MM.yyyy";

            DateTime parsedDate = DateTime.ParseExact(
                textFirst, format, CultureInfo.InvariantCulture);

            DateTime parsedSecondDate = DateTime.ParseExact(
               textSecond, format, CultureInfo.InvariantCulture);

            TimeSpan span = parsedSecondDate.Subtract(parsedDate);
            Console.WriteLine("Distance: {0} days", span.TotalDays);
        }
    }
}
