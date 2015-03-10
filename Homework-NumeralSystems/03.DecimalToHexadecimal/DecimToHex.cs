using System;
using System.Collections.Generic;
using System.Linq;
//Write a program to convert decimal numbers to their hexadecimal representation.
namespace _03.DecimalToHexadecimal
{
    class DecimToHex
    {
        static void Main()
        {
            Console.Write("Enter your Number : ");
            DecimalToHex(long.Parse(Console.ReadLine()));
        }
        static char[] DecimalToHex(long n)
        {
            string result = "";
            long index = 16;
            Console.Write("{0} converted to Hexadecimal is : ", n);
            while (n != 0)
            {
                long reminder = n % index;
                string reminderToString = Convert.ToString(reminder);
                if (reminder>9)
                {
                    switch (reminder)
                    {
                        case 10: reminderToString = "A"; break;
                        case 11: reminderToString = "B"; break;
                        case 12: reminderToString = "C"; break;
                        case 13: reminderToString = "D"; break;
                        case 14: reminderToString = "E"; break;
                        case 15: reminderToString = "F"; break;
                        default:
                            break;
                    }
                }
                
                result += reminderToString;
                long nextNumber = n / index;
                n = nextNumber;
            }
            char[] reversedResult = result.ToCharArray();
            Array.Reverse(reversedResult);
            Console.WriteLine(string.Join("", reversedResult));
            return reversedResult;
        }
    }
}
