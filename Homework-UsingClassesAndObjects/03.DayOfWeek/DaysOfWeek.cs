using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that prints to the console which day of the week is today.
//Use System.DateTime
namespace _03.DayOfWeek
{
    class DaysOfWeek
    {
        static void Main()
        {
            DateTime day = DateTime.Now;
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
