using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented 
//as array of digits by given integer number.

namespace _10.NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);    
        }
        private static void Factorial(int n)
        {
            BigInteger sum = n;
            for (BigInteger i = n - 1; i > 0; i--)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
