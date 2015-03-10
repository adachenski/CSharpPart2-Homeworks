using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
namespace _06.StringLength
{
    class StringLenght
    {
        static void Main()
        {
            Console.Write("Enter Some Text: ");
            string input = Console.ReadLine();
            int charecterCount = input.Length;
            int starsNeedet = 20 - charecterCount;
            if (input.Length<20)
            {
                string aaddedStars = new string('*', starsNeedet);
                input += aaddedStars;

            }
            Console.WriteLine(input);

        }
    }
}
