using System;
using System.Collections.Generic;
using System.Text;

namespace _06.binaryToHexadecimal
{
    class BinToHex
    {
        static void Main()
        {
            Console.Write("Enter your binary number : ");
            BinaryToHexadecimal(Console.ReadLine());
        }
        static string BinaryToHexadecimal(string binaryNumber)
        {
            string result = string.Empty;
            string firstFour = string.Empty;
            bool leadingZeros = false;
            int tempCount = 0;
            for (int i = 0; i < binaryNumber.Length; i += 4)
            {
                if (leadingZeros)
                {
                    i = 4 - tempCount;
                    leadingZeros = false;
                }
                if (i == 0 && binaryNumber.Length % 4 != 0)//this test is for adding extra zeros
                {                                          //if the totalDigitCount %4 != 0
                    int tempLenght = binaryNumber.Length;  //you don't need this if statment if you
                                                           //aways enter enought DigitsCount that %4 ==0
                    if (tempLenght % 4 != 0)
                    {
                        while (tempLenght % 4 != 0)
                        {
                            tempCount++;
                            firstFour += '0';
                            tempLenght++;
                        }
                        for (int j = 0; j < 4 - tempCount; j++)
                        {
                            firstFour += binaryNumber[i];
                            leadingZeros = true;
                        }
                    }
                }
                else
                {

                    firstFour = binaryNumber.Substring(i, 4);
                }

                switch (firstFour)
                {
                    case "0000": result += '0'; break;
                    case "0001": result += '1'; break;
                    case "0010": result += '2'; break;
                    case "0011": result += '3'; break;
                    case "0100": result += '4'; break;
                    case "0101": result += '5'; break;
                    case "0110": result += '6'; break;
                    case "0111": result += '7'; break;
                    case "1000": result += '8'; break;
                    case "1001": result += '9'; break;
                    case "1010": result += 'A'; break;
                    case "1011": result += 'B'; break;
                    case "1100": result += 'C'; break;
                    case "1101": result += 'D'; break;
                    case "1110": result += 'E'; break;
                    case "1111": result += 'F'; break;
                    default:
                        Console.WriteLine("Invalid Number !!!");
                        return result = string.Empty;

                }
            }
            Console.Write("Your Hexadecimal representation is : ");
            Console.WriteLine(result);
            return result;
        }
    }
}
