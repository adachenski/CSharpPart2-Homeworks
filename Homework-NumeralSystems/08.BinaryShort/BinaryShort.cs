using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that shows the binary representation of 
//given 16-bit signed integer number (the C# type short).
namespace _08.BinaryShort
{
    class BinaryShort
    {
        static bool isPositive = true;
        static void Main()
        {
            Console.Write("Enter your Number : ");
            long n = long.Parse(Console.ReadLine());
            if (n < 0)
            {
                n = n * -1;
                isPositive = false;
            }
            DecimalToBinary(n);
        }
        static char[] DecimalToBinary(long n)
        {

            string result = "";
            long index = 2;
            Console.Write("Your number to binary is : ");
            while (n != 0)
            {
                long reminder = n % index;
                string reminderToString = Convert.ToString(reminder);
                result += reminderToString;
                long nextNumber = n / index;
                n = nextNumber;
            }
            char[] reversedResult = result.ToCharArray();
            Array.Reverse(reversedResult);
            if (isPositive)
            {
                Console.WriteLine(string.Join("", reversedResult).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine(string.Join("", reversedResult).PadLeft(16, '1'));
            }
            return reversedResult;
        }
    }
}
