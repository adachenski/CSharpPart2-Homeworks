using System;
using System.Collections.Generic;
using System.Linq;
//Write a program to convert binary numbers to their decimal representation.
namespace _02.BinaryToDecimal
{
    class BinaryToDec
    {
        static void Main()
        {
            Console.Write("Enter your binary number : ");
            BinaryToDecimal(Console.ReadLine());
        }
        static long BinaryToDecimal(string number)//0111
        {
            long result = 0;
            int decimalIndex = 2;
            for (int i = 0; i < number.Length; i++)
            {
                int firstDigit = number[i] - '0';
                if (firstDigit!=1 &&firstDigit!= 0)
                {
                    Console.WriteLine("Invalid Number !!!");
                    return result=0;
                }
                int position = number.Length-i-1;
                result += firstDigit * (int)Math.Pow(decimalIndex, position);
            }
            Console.Write("Your number to decimal is : ");
            Console.WriteLine(result);
            return result;
        }
    }
}
