using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
namespace _18.ExtractE_mails
{
    class ExtractEmails
    {
        static void Main()
        {
            string text = "Write a program that reads a string from bossoman64@yahoo.net the console and prints all different "
            + "letters in the string some_32j@aol.co along with information how test@2s-company.com many times each letter is found.";

            emas(text);
        }
        public static void emas(string text)
        {
            const string MatchEmailPattern =@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}";
           //@"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           //+ @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
           //  + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           //+ @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
            Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            // Find matches.
            MatchCollection matches = rx.Matches(text);
            // Report the number of matches found.
            int noOfMatches = matches.Count;
            // Report on each match.
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.ToString());
            }
        }
    }
}
