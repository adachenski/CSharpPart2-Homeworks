using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
namespace _19.DatesFromTextInCanada
{
    class DatesFromTxt
    {
        static void Main()
        {
             
             System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

            string text = "Write a program that reads a string from 16.03.2013 the "
            + "console and prints all different 22.11.2012."
            + "letters in the string 26.03.2016 along with information"
            +" how test@2s-company.com many times each letter is found.";

             var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");//en-CA

             foreach (Match m in regex.Matches(text))
             {
            
                 DateTime dt;
                 if (DateTime.TryParseExact(m.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt))
                     Console.WriteLine(dt.ToString());
             }
        }
        //static DateTime? GetFirstDateFromString(string inputText)
        //{
        //    var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");
        //    foreach (Match m in regex.Matches(inputText))
        //    {
        //        DateTime dt;
        //        if (DateTime.TryParseExact(m.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt))
        //            return dt;
        //    }
        //    return null;
        //}
    }
}
