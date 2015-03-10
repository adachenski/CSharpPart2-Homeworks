using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a year from the console and 
//checks whether it is a leap one.
//using System.DateTime;
namespace _01.LeapYears
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter Year = ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Month = ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter Day = ");
            int day = int.Parse(Console.ReadLine());
            DateTime leapYear = new DateTime(year, month, day);
            Console.WriteLine("Is {0} a leap year? {1}", year, DateTime.IsLeapYear(leapYear.Year));
        }
    }
}
