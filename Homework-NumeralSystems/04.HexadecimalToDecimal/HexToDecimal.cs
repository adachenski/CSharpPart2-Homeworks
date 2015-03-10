using System;
using System.Collections.Generic;
using System.Linq;
//Write a program to convert hexadecimal numbers to their decimal representation.
namespace _04.HexadecimalToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
           
            Console.Write("Enter your Hexadecimal number : ");
            BinaryToDecimal(Console.ReadLine());
        }
        static long BinaryToDecimal(string number)
        {
            long result = 0;
            int decimalIndex = 16;
            for (int i = 0; i < number.Length; i++)
            {
                char chech = number[i];

                int firstDigit = number[i] - '0';
                if (chech >= 'A' && chech <= 'F')
                {
                    switch (chech)
                    {
                        case 'A': firstDigit = 10; break;
                        case 'B': firstDigit = 11; break;
                        case 'C': firstDigit = 12; break;
                        case 'D': firstDigit = 13; break;
                        case 'E': firstDigit = 14; break;
                        case 'F': firstDigit = 15; break;
                    }
                }
                if (firstDigit < 0 | firstDigit > 15) 
                {
                    Console.WriteLine("Invalid Number !!!");
                    return result = 0;
                }
                int position = number.Length - i - 1;
                result += firstDigit * (int)Math.Pow(decimalIndex, position);
            }
           
            Console.Write("Your number to decimal is : ");
            Console.WriteLine(result);
            return result;
        }
    }
}
