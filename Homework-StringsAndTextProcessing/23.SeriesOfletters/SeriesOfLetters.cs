using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string from the 
//console and replaces all series of 
//consecutive identical letters with a single one.
namespace _23.SeriesOfletters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    Console.Write(input[i]);
                }
                if (i == input.Length - 2)
                {
                    Console.Write(input[i + 1]);
                }
            }
        }
    }
}
