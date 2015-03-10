using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that calculates the number
//of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except 
//a fixed list of public holidays specified preliminary as array
namespace _05.Workdays
{
    class WorkDays
    {
        static void Main()
        {
            Console.Write("Enter Start Year = ");
            int currentYear = int.Parse(Console.ReadLine());
            Console.Write("Enter Start Month = ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter Start Day = ");
            int day = int.Parse(Console.ReadLine());
            DateTime startDate = new DateTime(currentYear, month, day);
            Console.Write("Enter End Year = ");
            int endYear = int.Parse(Console.ReadLine());
            Console.Write("Enter End Month = ");
            int endMonth = int.Parse(Console.ReadLine());
            Console.Write("Enter End Day = ");
            int endDay = int.Parse(Console.ReadLine());
            DateTime endDate = new DateTime(endYear, endMonth, endDay);


            CalculatingWorkingDaysInTimeFrime(currentYear, startDate, endDate);
        }

        private static void CalculatingWorkingDaysInTimeFrime
            (int currentYear, DateTime startDate, DateTime endDate)
        {
            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(currentYear, 1, 1));
            holidays.Add(new DateTime(currentYear, 2, 2));
            holidays.Add(new DateTime(currentYear, 3, 3));
            holidays.Add(new DateTime(currentYear, 1, 5));
            holidays.Add(new DateTime(currentYear, 6, 5));
            holidays.Add(new DateTime(currentYear, 9, 22));
            holidays.Add(new DateTime(currentYear, 9, 22));
            holidays.Add(new DateTime(currentYear, 12, 24));
            holidays.Add(new DateTime(currentYear, 12, 25));
            holidays.Add(new DateTime(currentYear, 12, 26));
            holidays.Add(new DateTime(currentYear, 12, 31));

            DayOfWeek sat = DayOfWeek.Saturday;
            DayOfWeek sun = DayOfWeek.Sunday;
            int count = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                ++count;
                DayOfWeek dw = date.DayOfWeek;
                if (dw == sat || dw == sun)
                {
                    --count;
                    foreach (var item in holidays)
                    {
                        if (date == item)
                        {
                            ++count;
                        }
                    }

                }
                foreach (var item in holidays)
                {
                    if (date == item)
                    {
                        --count;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Between the period \"{0}\" and \"{1}\" "
                + "\nhas \"{2}\" working days. ", startDate.ToString("dd-MM-yyyy"),
                    endDate.ToString("dd-MM-yyyy"), count);
        }
    }
}
