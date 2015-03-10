using System;
using System.Collections.Generic;
using System.Linq;
//Write a program to convert hexadecimal numbers to binary numbers (directly).
namespace _05.HexadecimalToBinary
{
    class HexToBinary
    {
        static void Main()
        {
            Console.Write("Enter your Hexadecimal Number : ");
            HexToBin(Console.ReadLine());
        }
        static string HexToBin(string hexNumber)
        {
            string result = string.Empty;
            for (int i = 0; i < hexNumber.Length; i++)
            {
                char firstDigit = hexNumber[i];
                switch (firstDigit)
                {
                    case '0': result += "0000"; break;
                    case '1': result += "0001"; break;
                    case '2': result += "0010"; break;
                    case '3': result += "0011"; break;
                    case '4': result += "0100"; break;
                    case '5': result += "0101"; break;
                    case '6': result += "0110"; break;
                    case '7': result += "0111"; break;
                    case '8': result += "1000"; break;
                    case '9': result += "1001"; break;
                    case 'A': result += "1010"; break;
                    case 'B': result += "1011"; break;
                    case 'C': result += "1100"; break;
                    case 'D': result += "1101"; break;
                    case 'E': result += "1110"; break;
                    case 'F': result += "1111"; break;
                    default:
                        Console.WriteLine("Invalid Number !!!");
                        return result = string.Empty;

                }
            }
            Console.Write("Your binary representation is : ");
            Console.WriteLine(result);
            return result;
        }
    }
}
