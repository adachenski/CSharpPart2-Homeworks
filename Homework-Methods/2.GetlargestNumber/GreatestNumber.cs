using System;
using System.Collections.Generic;
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()

namespace _2.GetlargestNumber
{
    class GreatestNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter Three numbers ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
           int max= GetMax(a, b, c);
           Console.WriteLine("The max number is: "+max);
        }
        static int GetMax(int a, int b, int c)
        {
            int temp = a > b ? a : b;
            int result = temp > c ? temp : c;
            return result;
        }
    }
}
