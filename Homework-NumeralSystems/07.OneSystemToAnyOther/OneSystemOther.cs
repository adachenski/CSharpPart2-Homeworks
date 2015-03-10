using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that shows the binary representation 
//of given 16-bit signed integer number (the C# type short).

namespace _07.OneSystemToAnyOther
{
    class OneSystemOther
    {
        static void Main()
        {
            long firstPartConversion = 0;

            Console.Write("Enter the system you want to START from : ");
            int startSystem = int.Parse(Console.ReadLine());
            Console.Write("Enter your number in {0}th base system : ",startSystem);
            string number = Console.ReadLine();
            Console.Write("Now enter the system you want END to :");
            int endSystem = int.Parse(Console.ReadLine());

            if (startSystem > 10)
            {
                long moreThan10 = HexToDecimal(number, startSystem);
                AnyToHex(moreThan10, endSystem);
            }
            else
            {
                firstPartConversion = AnyToDecimal(startSystem, number);
                if (endSystem<=10)
                {
                    DecimalToAnt(firstPartConversion, endSystem);
                }
                else
                {
                    AnyToHex(firstPartConversion, endSystem);
                }
            }
             
        }

        static long AnyToDecimal(int startSystem, string number)
        {
            long result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int firstDigit = number[i] - '0';
                if (firstDigit >= 0 && firstDigit < startSystem)
                {
                    int position = number.Length - i - 1;
                    result += firstDigit * (int)Math.Pow(startSystem, position);
                }
                else
                {
                    Console.WriteLine("Invalid Number !!!");
                    return result = 0;
                }
               
            }
            return result;
        }
        static char[] AnyToHex(long n,long index)
        {
            string result = "";
            Console.Write("Your number to {0}th base system is : ", index);
            while (n != 0)
            {
                long reminder = n % index;
                string reminderToString = Convert.ToString(reminder);
                if (reminder > 9)
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
        static char[] DecimalToAnt(long n,int index)
        {
            string result = "";
            Console.Write("Your number to {0}nd base sysem is is : ",index);
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
            Console.WriteLine(string.Join("", reversedResult));
            return reversedResult;
        }
        static long HexToDecimal(string number,int decimalIndex)
        {
            long result = 0;
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
                if (firstDigit >= decimalIndex)
                {
                    Console.WriteLine("Invalid Number !!!");
                    return result = 0;
                }
                int position = number.Length - i - 1;
                result += firstDigit * (int)Math.Pow(decimalIndex, position);
            }
            return result;
        }
    }
}
