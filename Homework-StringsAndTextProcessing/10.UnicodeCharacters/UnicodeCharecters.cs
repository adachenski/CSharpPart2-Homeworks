using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that converts a string to a sequence of 
//C# Unicode character literals. Use format strings.
namespace _10.UnicodeCharacters
{
    class UnicodeCharecters
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string input = Console.ReadLine();
            string hex = "";
            foreach (char c in input)
            {
                int tmp = c;
                hex += @"\u00";
                hex += String.Format("{0:x2}",Convert.ToUInt32(tmp.ToString()));
            }
            Console.WriteLine(hex);
        }
    }
}
