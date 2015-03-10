using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that parses an URL address given in the format: [protocol]:
//[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            Uri myUri = new Uri("http://telerikacademy.com/Courses/Courses/Details/212");

            string baseUrl =myUri.ToString();
            if (baseUrl[4]=='s')
            {
                Console.WriteLine("[protocol] = https");
            }
            else
            {
                Console.WriteLine("[protocol] = http");
            }
            Console.WriteLine("[server] = {0}",myUri.Host);
            Console.WriteLine("[resource] = {0}", myUri.LocalPath);
        }
    }
}
