using System;
using System.Collections.Generic;
using System.Linq;
//Write a method that reverses the digits of given decimal number.
namespace _07.ReverseNumber
{
    class ReverseNumbers
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Reverse(number);
        }
        static void Reverse(string n)
        {
            char[] arrey = n.ToCharArray();
            Array.Reverse(arrey);
            Console.WriteLine(string.Join("", arrey));
        }
    }
}
