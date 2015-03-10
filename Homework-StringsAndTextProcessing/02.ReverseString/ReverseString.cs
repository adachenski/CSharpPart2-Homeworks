using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string, reverses it and prints the result at the console.
namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char [] reverse = input.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(string.Join("",reverse));

        }
    }
}
