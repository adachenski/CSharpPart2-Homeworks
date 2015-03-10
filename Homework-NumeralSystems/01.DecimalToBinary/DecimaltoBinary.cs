using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program to convert decimal numbers to their binary representation.
namespace _01.DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your Number : ");
            DecimalToBinary(long.Parse(Console.ReadLine()));
        }
        static char[] DecimalToBinary(long n)
        {
            string result = "";
            long index =2;
            Console.Write("{0} converted to binary is : ", n);
            while (n!=0)
            {
                long reminder = n % index;
                string reminderToString = Convert.ToString(reminder);
                result += reminderToString;
                long nextNumber = n / index;
                n = nextNumber;
            }
            char[] reversedResult = result.ToCharArray();
            Array.Reverse(reversedResult);
            Console.WriteLine(string.Join("",reversedResult));
            return reversedResult;
        }
    }
}
