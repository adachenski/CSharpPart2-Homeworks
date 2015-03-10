using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a number and prints it as a decimal 
//number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.
namespace _11.FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15:D}|\n{0,15:X}|\n{0,15:P}|\n{0,15:E}|",number,number,number,number);
        }
    }
}
